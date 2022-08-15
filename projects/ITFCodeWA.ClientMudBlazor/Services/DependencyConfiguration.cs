using ITFCodeWA.ClientMudBlazor.Services.Api.Documents;
using ITFCodeWA.ClientMudBlazor.Services.Api.Documents.Interfaces;
using ITFCodeWA.ClientMudBlazor.Services.Api.References;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.ClientMudBlazor.Services.Api.Totals;
using ITFCodeWA.ClientMudBlazor.Services.Api.Totals.Interfaces;

namespace ITFCodeWA.ClientMudBlazor.Services
{
    public static class DependencyConfiguration
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            // References 
            services.AddScoped<IContractorService, ContractorService>();
            services.AddScoped<IContractService, ContractService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
            services.AddScoped<IExpenseItemService, ExpenseItemService>();
            services.AddScoped<IFoodService, FoodService>();
            services.AddScoped<IGoodService, GoodService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IRevenueItemService, RevenueItemService>();

            // Documents
            services.AddScoped<IWeightRegistratorService, WeightRegistratorService>();

            // Totals
            services.AddScoped<IWeightTotalService, WeightTotalService>();
        }
    }
}