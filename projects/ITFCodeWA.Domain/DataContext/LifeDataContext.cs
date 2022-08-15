using ITFCodeWA.Core.Domain.DataContext;
using ITFCodeWA.Core.Domain.EntityConfiguration.Base;
using ITFCodeWA.Core.Domain.EntityConfigurations;
using ITFCodeWA.Data.Documents;
using ITFCodeWA.Data.References;
using ITFCodeWA.Domain.DataContext.Interfaces;
using ITFCodeWA.Domain.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ITFCodeWA.Domain.DataContext
{
    public class LifeDataContext : DataContextCore, ILifeDataContext
    {
        #region Public Properties

        public DbSet<Contract> Contract { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<ExpenseGroup> ExpenseGroups { get; set; }
        public DbSet<ExpenseItem> ExpenseItems { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodGroup> FoodGroups { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<GoodGroup> GoodGroups { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<RevenueGroup> RevenueGroups { get; set; }
        public DbSet<RevenueItem> RevenueItems { get; set; }

        public DbSet<WeightRegistrator> WeightRegistrators { get; set; }
        public DbSet<WeightRegistratorRow> WeightRegistratorRows { get; set; }

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
                typeof(EntityConfigurationBase<,>),
                typeof(ReferenceConfiguration<>),
                typeof(DocumentConfiguration<>)
            };

            BuildModelConfigurations(modelBuilder, baseTypes, Assembly.GetExecutingAssembly().GetTypes());
        }

        #endregion
    }
}