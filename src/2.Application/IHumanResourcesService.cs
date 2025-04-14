using Domain.DbFirst.Entities;

namespace Application
{
    public interface IHumanResourcesService
    {
       Task CreateEmployee(Employee employee);
       Task<IEnumerable<Employee>> GetAllEmployees();
    }
}