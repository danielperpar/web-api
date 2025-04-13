using Application.Mapper;

namespace web_api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApiDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMapper, Mapper>();
            return serviceCollection;
        }
    }
}
