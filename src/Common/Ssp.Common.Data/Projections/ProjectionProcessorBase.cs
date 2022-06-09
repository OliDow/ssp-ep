using MediatR;

namespace Ssp.Common.Data.Projections;

public abstract class ProjectionProcessorBase
{
    private readonly IProjectionRepository _projectionRepository;
    private readonly IList<IProjectionGenerator> _projectionGenerators;

    protected ProjectionProcessorBase(IProjectionRepository projectionRepository,
        IList<IProjectionGenerator> projectionGenerators)
    {
        _projectionRepository = projectionRepository ?? throw new ArgumentNullException(nameof(projectionRepository));
        _projectionGenerators = projectionGenerators ?? throw new ArgumentNullException(nameof(projectionGenerators));
    }

    protected async Task<Unit> GetProjectionData(IEvent @event, string partitionKey, CancellationToken cancellationToken)
    {
        // Detect Projects associated with this event
        var generators = _projectionGenerators.Where(g => g.UpdateEvent.Contains(@event.GetType())).ToList();

        // Fetch these projections
        // Todo Add Open Generics and filter by above type when dealing with a second projection
        var existingProjections =
            await _projectionRepository.GetProjectionsAsync(partitionKey, cancellationToken);

        // todo Fix potential Race condition where two generators update the same projection & Potential for parallelism
        foreach (var generator in generators)
        {
            var generatedProjections = generator.Generate(@event, existingProjections);
            await _projectionRepository.UpsertAsync(generatedProjections, cancellationToken);
        }

        return Unit.Value;
    }
}