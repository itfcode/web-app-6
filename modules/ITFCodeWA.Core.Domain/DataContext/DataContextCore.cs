using ITFCodeWA.Core.Domain.DataContext.Interfaces;
using ITFCodeWA.Core.Domain.EntityConfiguration;
using ITFCodeWA.Core.Domain.EntityConfiguration.Base;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ITFCodeWA.Core.Domain.DataContext
{
    public abstract class DataContextCore : DbContext, IDataContextCore
    {
        #region Private & Protected Fields 

        protected readonly DbContextOptions _options;

        protected virtual Assembly ExecutingAssembly => Assembly.GetExecutingAssembly();

        #endregion

        #region Constructors 

        public DataContextCore(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        #endregion

        #region Protected Methods 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            BuildModelConfigurations(modelBuilder, typeof(EntityConfigurationCore<,>), ExecutingAssembly.GetTypes());
        }

        protected void BuildModelConfigurations(ModelBuilder modelBuilder, Type baseType, Type[] types)
        {
            ArgumentNullException.ThrowIfNull(modelBuilder, nameof(modelBuilder));
            ArgumentNullException.ThrowIfNull(baseType, nameof(baseType));
            ArgumentNullException.ThrowIfNull(types, nameof(types));

            types.Where(type =>
                    (type.BaseType != null && type.BaseType.IsGenericType && !type.IsAbstract)
                    &&
                    (type.BaseType.GetGenericTypeDefinition() == baseType))
                .ToList()
                .ForEach(type =>
                {
                    dynamic instance = Activator.CreateInstance(type) ?? throw new NullReferenceException();
                    modelBuilder.ApplyConfiguration(instance);
                });
        }

        protected void BuildModelConfigurations(ModelBuilder modelBuilder, Type[] baseTypes, Type[] types)
        {
            ArgumentNullException.ThrowIfNull(baseTypes, nameof(baseTypes));

            foreach (var baseType in baseTypes)
                BuildModelConfigurations(modelBuilder, baseType, types);
        }

        #endregion

    }
}