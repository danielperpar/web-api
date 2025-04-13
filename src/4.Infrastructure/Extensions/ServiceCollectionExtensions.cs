using DbFirst.Infrastructure.Repository;
using Domain.DbFirst.Entities.Repository;
using Domain.DbFirst.Entities.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using DbFirst.Infrastructure.DbFirst;

namespace DbFirst.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IEmployeeRepository, EmployeeRepository>();
            serviceCollection.AddScoped<IWorkingExperienceRepository, WorkingExperienceRepository>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            return serviceCollection;
        }
    }
}
