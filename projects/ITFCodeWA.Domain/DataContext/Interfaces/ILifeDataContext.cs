using ITFCodeWA.Core.Domain.DataContext.Interfaces;
using ITFCodeWA.Data.Common.Reference;
using ITFCodeWA.Data.Finance.References;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Domain.DataContext.Interfaces
{
    public interface ILifeDataContext : IDataContextCore
    {
        DbSet<Person> Persons { get; set; }

        DbSet<Contract> Contract { get; set; }
        DbSet<Contractor> Contractors { get; set; }
        DbSet<Currency> Currencies { get; set; }
        DbSet<ExpenseItem> ExpenseItems { get; set; }
        DbSet<Good> Goods { get; set; }
        DbSet<RevenueItem> RevenueItems { get; set; }


    }
}
