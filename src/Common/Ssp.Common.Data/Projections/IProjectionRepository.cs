namespace Ssp.Common.Data.Projections;

public interface IProjectionRepository
{
    Task<IReadOnlyCollection<IProjection>> GetProjectionsAsync(string partitionKey, CancellationToken cancellationToken);

    Task UpsertAsync(ICollection<IProjection> generatedProjections, CancellationToken cancellationToken);
}