using ITFCodeWA.Core.Domain.DataContext.Interfaces;
using ITFCodeWA.Core.Domain.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ITFCodeWA.Core.Domain.DataContext
{
    public abstract class DataContextCore : DbContext, IDataContextCore
    {
        #region Private & Protected Fields 

        protected readonly DbContextOptions _options;

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

            BuildGenericModelConfigurations(modelBuilder, typeof(EntityConfigurationCore<,>));
        }

        protected void BuildGenericModelConfigurations(ModelBuilder modelBuilder, Type baseType)
        {
            Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type =>
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

        #endregion

    }
}