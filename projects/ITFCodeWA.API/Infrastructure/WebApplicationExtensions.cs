using ITFCodeWA.InitialData.InitService.Interfaces;

namespace ITFCodeWA.API.Infrastructure
{
    public static class WebApplicationExtensions
    {
        public static void InitializeProjectData(this WebApplication app)
        {
            using var serviceScope = app.Services.CreateScope();
            var services = serviceScope.ServiceProvider;

            var initializerService = services.GetRequiredService<IDatabaseInitializerService>();
            initializerService.InitializeData();
        }
    }
}
