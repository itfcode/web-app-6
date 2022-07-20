using ITFCodeWA.Core.Domain.DataContext;
using ITFCodeWA.Data.Common.Reference;
using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Domain.DataContext.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Domain.DataContext
{
    public class DataContext : DataContextCore, IDataContext
    {
        #region Public Properties 

        public DbSet<Person> Persons { get; set; }

        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<ExpenseItem> ExpenseItems { get; set; }
        public DbSet<RevenueItem> RevenueItems { get; set; }

        #endregion

        #region Constuctors

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        #endregion

        #region Protected Propetected 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}