using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.Documents;
using ITFCodeWA.Domain.Repositories.Documents.Interfaces;
using ITFCodeWA.Domain.Repositories.References;
using ITFCodeWA.Domain.Repositories.References.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ITFCodeWA.Domain.Repositories
{
    public static class DomainDependencyConfiguration
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<DbContext, LifeDataContext>();

            // repository registration of References   
            services.AddScoped<IContractorRepository, ContractorRepository>();
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<IExpenseItemRepository, ExpenseItemRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
            services.AddScoped<IGoodRepository, GoodRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IRevenueItemRepository, RevenueItemRepository>();

            // repository registration of Documents   
            services.AddScoped<IWeightRegistratorRepository, WeightRegistratorRepository>();

        }
    }
}