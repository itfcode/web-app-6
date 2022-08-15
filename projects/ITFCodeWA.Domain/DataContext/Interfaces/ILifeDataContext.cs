using ITFCodeWA.Core.Domain.DataContext.Interfaces;
using ITFCodeWA.Data.Documents;
using ITFCodeWA.Data.References;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Domain.DataContext.Interfaces
{
    public interface ILifeDataContext : IDataContextCore
    {
        DbSet<Contract> Contract { get; set; }
        DbSet<Contractor> Contractors { get; set; }
        DbSet<Currency> Currencies { get; set; }
        DbSet<ExpenseGroup> ExpenseGroups { get; set; }
        DbSet<ExpenseItem> ExpenseItems { get; set; }
        DbSet<Food> Foods { get; set; }
        DbSet<FoodGroup> FoodGroups { get; set; }
        DbSet<Good> Goods { get; set; }
        DbSet<GoodGroup> GoodGroups { get; set; }
        DbSet<Person> Persons { get; set; }
        DbSet<RevenueGroup> RevenueGroups { get; set; }
        DbSet<RevenueItem> RevenueItems { get; set; }

        DbSet<WeightRegistrator> WeightRegistrators { get; set; }
        DbSet<WeightRegistratorRow> WeightRegistratorRows { get; set; }
    }
}