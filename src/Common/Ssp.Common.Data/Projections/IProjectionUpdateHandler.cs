using MediatR;

namespace Ssp.Common.Data.Projections;

public interface IProjectionUpdateHandler<in T> : IRequestHandler<T>
    where T : IRequest<Unit>
{ }