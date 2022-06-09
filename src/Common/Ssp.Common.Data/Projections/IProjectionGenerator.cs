namespace Ssp.Common.Data.Projections;

public interface IProjectionGenerator
{
    List<Type> UpdateEvent { get; }

    ICollection<IProjection> Generate(IEvent @event, IReadOnlyCollection<IProjection> projections);
}