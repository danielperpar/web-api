using Application.Dto;
using Domain.DbFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
