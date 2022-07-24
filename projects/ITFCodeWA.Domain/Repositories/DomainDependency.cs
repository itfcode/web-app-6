using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.Common.References;
using ITFCodeWA.Domain.Repositories.Common.References.Interfaces;
using ITFCodeWA.Domain.Repositories.Finance.References;
using ITFCodeWA.Domain.Repositories.Finance.References.Intrefaces;
using ITFCodeWA.Domain.Repositories.Health.References;
using ITFCodeWA.Domain.Repositories.Health.References.Intrefaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ITFCodeWA.Domain.Repositories
{
    public static class DomainDependency
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<DbContext, LifeDataContext>();

            // repository registration of Common   
             services.AddScoped<IPersonRepository, PersonRepository>();

            // repository registration of Finance   
            services.AddScoped<IContractorRepository, ContractorRepository>();
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<IExpenseItemRepository, ExpenseItemRepository>();
            services.AddScoped<IGoodRepository, GoodRepository>();
            services.AddScoped<IRevenueItemRepository, RevenueItemRepository>();

            // repository registration of  Health  
            services.AddScoped<IFoodRepository, FoodRepository>();
        }
    }
}