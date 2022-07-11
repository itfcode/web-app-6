using ITFCodeWA.Core.CQRS.Queries.Base.Interfaces;

namespace ITFCodeWA.Core.CQRS.Queries.Base
{
    public abstract class QueryBase<TEntityDTO> : IQuery<TEntityDTO> where TEntityDTO : class
    {
    }

    public abstract class QueryBase<TEntityDTO, TResponse> : IQuery<TEntityDTO, TResponse> where TEntityDTO : class
    {
    }
}
