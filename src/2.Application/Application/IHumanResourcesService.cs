using Application.Dto;
using Domain.DbFirst.Entities;

namespace Application
{
    public interface IHumanResourcesService
    {
       Task CreateEmployee(Employee employeeDto);
       Task<IEnumerable<Employee>> GetAllEmployees();
    }
}