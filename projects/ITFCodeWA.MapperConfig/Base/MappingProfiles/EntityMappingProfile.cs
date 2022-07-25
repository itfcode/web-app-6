namespace ITFCodeWA.MapperConfig.Base.MappingProfiles
{
    public abstract class EntityMappingProfile<TEntity, TEntityModel> : AutoMapper.Profile
        where TEntity : class
        where TEntityModel : class
    {
        public EntityMappingProfile()
            => ConfigureMap();

        protected virtual void ConfigureMap()
            => CreateMap<TEntity, TEntityModel>()
                .ReverseMap();
    }
}