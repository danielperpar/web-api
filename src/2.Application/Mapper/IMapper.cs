using Application.Dto;
using Domain.DbFirst.Entities;

namespace Application.Mapper
{
    public interface IMapper
    {
        Employee MapDown(EmployeeDto employeeDto);
        EmployeeDto MapUp(Employee employee);
        IEnumerable<EmployeeDto> MapUp(IEnumerable<Employee> employees);
        WorkingExperience MapDown(WorkingExperienceDto workingExperienceDto);
        WorkingExperienceDto MapUp(WorkingExperience workingExperience);
    }
}
