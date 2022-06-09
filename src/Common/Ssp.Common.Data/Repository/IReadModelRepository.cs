using Ssp.Common.Data.Projections;

namespace Ssp.Common.Data.Repository;

public interface IReadModelRepository<T>
    where T : IProjection
{
    Task<IEnumerable<T>> GetAllAsync();

    Task<T> GetByIdAsync(string id);
}