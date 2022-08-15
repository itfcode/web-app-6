namespace ITFCodeWA.MapperConfig.Base.MappingProfiles
{
    public abstract class EntityMappingProfile<TEntity, TEntityModel> : AutoMapper.Profile
        where TEntity : class
        where TEntityModel : class
    {
        #region Constructors

        public EntityMappingProfile()
            => ConfigureMap();

        #endregion

        #region Private && Protected Methods 

        /// <summary>
        /// To confure mapping 
        /// </summary>
        protected virtual void ConfigureMap()
            => CreateMap<TEntity, TEntityModel>()
                .ReverseMap();

        #endregion
    }
}