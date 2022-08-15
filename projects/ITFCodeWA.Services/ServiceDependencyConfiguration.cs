using ITFCodeWA.Services.DataServices.Documents;
using ITFCodeWA.Services.DataServices.Documents.Interfaces;
using ITFCodeWA.Services.DataServices.References;
using ITFCodeWA.Services.DataServices.References.Interfaces;
using ITFCodeWA.Services.TotalServices.Health;
using ITFCodeWA.Services.TotalServices.Health.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ITFCodeWA.Services
{
    public static class ServiceDependencyConfiguration
    {
        public static void Register(IServiceCollection services)
        {
            // services registration of References
            services.AddScoped<IContractDataService, ContractDataService>();
            services.AddScoped<IContractorDataService, ContractorDataService>();
            services.AddScoped<ICurrencyDataService, CurrencyDataService>();
            services.AddScoped<IExpenseGroupDataService, ExpenseGroupDataService>();
            services.AddScoped<IExpenseItemDataService, ExpenseItemDataService>();
            services.AddScoped<IFoodDataService, FoodDataService>();
            services.AddScoped<IFoodGroupDataService, FoodGroupDataService>();
            services.AddScoped<IGoodDataService, GoodDataService>();
            services.AddScoped<IGoodGroupDataService, GoodGroupDataService>();
            services.AddScoped<IPersonDataService, PersonDataService>();
            services.AddScoped<IRevenueGroupDataService, RevenueGroupDataService>();
            services.AddScoped<IRevenueItemDataService, RevenueItemDataService>();

            // service registration of Documents   
            services.AddScoped<IWeightRegistratorDataService, WeightRegistratorDataService>();

            // services registration of Health : Totals
            services.AddScoped<IWeightTotalService, WeightTotalService>();
        }
    }
}