using AutoMapper;
using ITFCodeWA.Domain.DataContext.Interfaces;

namespace ITFCodeWA.MapperConfig.Base.Resolvers
{
    public abstract class EntityPropertyResolver<TEntity, TEntityModel, TDestMember> : IValueResolver<TEntity, TEntityModel, TDestMember>
        where TEntity : class
        where TEntityModel : class
    {
        protected ILifeDataContext Context { get; }

        public EntityPropertyResolver(ILifeDataContext context)
        {
            Context = context;
        }

        public abstract TDestMember Resolve(TEntity source, TEntityModel destination, TDestMember destMember, ResolutionContext context);
    }
}
