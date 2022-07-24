using ITFCodeWA.Core.Domain.DataContext;
using ITFCodeWA.Core.Domain.EntityConfiguration.Base;
using ITFCodeWA.Core.Domain.EntityConfigurations.Base;
using ITFCodeWA.Data.Common.Reference;
using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Data.Health.References;
using ITFCodeWA.Domain.DataContext.Interfaces;
using ITFCodeWA.Domain.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ITFCodeWA.Domain.DataContext
{
    public class LifeDataContext : DataContextCore, ILifeDataContext
    {
        #region Public Properties 

        public DbSet<Person> Persons { get; set; }

        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<ExpenseItem> ExpenseItems { get; set; }
        public DbSet<RevenueItem> RevenueItems { get; set; }

        public DbSet<Food> Foods { get; set; }

        #endregion

        #region Constuctors

        public LifeDataContext(DbContextOptions<LifeDataContext> options) : base(options)
        {
        }

        #endregion

        #region Protected Propetected 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var baseTypes = new Type[] 
            {
                typeof(EntityConfigurationCore<,>),
                typeof(ReferenceConfiguration<>),
                typeof(DocumentConfiguration<>)
            };

            BuildModelConfigurations(modelBuilder, baseTypes, Assembly.GetExecutingAssembly().GetTypes());
        }

        #endregion
    }
}