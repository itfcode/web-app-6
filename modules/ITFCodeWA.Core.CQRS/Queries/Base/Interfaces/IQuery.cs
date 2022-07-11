using MediatR;

namespace ITFCodeWA.Core.CQRS.Queries.Base.Interfaces
{
    public interface IQuery<TEntityDTO> : IRequest<TEntityDTO> where TEntityDTO : class
    {
    }

    public interface IQuery<TEntityDTO, TResponse> : IRequest<TEntityDTO> where TEntityDTO : class
    {
    }
}
