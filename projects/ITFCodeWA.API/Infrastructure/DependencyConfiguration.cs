using AutoMapper;
using ITFCodeWA.Core.Services.Operating;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using ITFCodeWA.Domain.Repositories;
using ITFCodeWA.InitialData.InitService;
using ITFCodeWA.InitialData.InitService.Interfaces;
using ITFCodeWA.MapperConfig.Base.MappingProfiles;
using ITFCodeWA.MapperConfig.Documents;
using ITFCodeWA.MapperConfig.References;
using ITFCodeWA.Services;

namespace ITFCodeWA.API.Infrastructure
{
    public static class DependencyConfiguration
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped<IDatabaseInitializerService, DatabaseInitializerService>();

            DomainDependencyConfiguration.Register(services);
            ServiceDependencyConfiguration.Register(services);

            RegisterMapper(services);
        }

        private static void RegisterMapper(IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                var parentTypes = new List<Type>
                {
                    typeof(ReferenceMappingProfile<,>),
                    typeof(DocumentMappingProfile<,>),
                    typeof(DocumentRowMappingProfile<,>)
                };

                typeof(PersonMappingProfile).Assembly
                    .GetTypes()
                    .Where(t => 
                        t.BaseType != null 
                        && t.BaseType.IsGenericType 
                        && !t.IsAbstract
                        && parentTypes.Contains(t.BaseType.GetGenericTypeDefinition())
                        )
                    .ToList()
                    .ForEach(t =>
                    {
                        var type = (AutoMapper.Profile)Activator.CreateInstance(t);
                        mc.AddProfile(type);
                    });
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
