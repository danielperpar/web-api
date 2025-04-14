using Application.Dto;
using Domain.DbFirst.Entities;

namespace Application.Mapper
{
    public class Mapper : IMapper
    {
        public Employee MapDown(EmployeeDto employeeDto)
        {
            var employee = new Employee()
            {
                EmployeeId = employeeDto.EmployeeId,
                EmployeeName = employeeDto.EmployeeName,
                WorkingExperiences = new List<WorkingExperience>(employeeDto.WorkingExperiences.Select(workingExpDto => MapDown(workingExpDto)))
            };

            return employee;
        }
        public EmployeeDto MapUp(Employee employee)
        {
            var employeeDto = new EmployeeDto()
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.EmployeeName,
                WorkingExperiences = new List<WorkingExperienceDto>(employee.WorkingExperiences.Select(workingExp => MapUp(workingExp)))
            };

            return employeeDto;
        }

        public IEnumerable<EmployeeDto> MapUp(IEnumerable<Employee> employees)
        {
            var employeeDtos = new List<EmployeeDto>(employees.Select(employee => MapUp(employee)));
            return employeeDtos;
        }

        public WorkingExperience MapDown(WorkingExperienceDto workingExpDto)
        {
            var workingExp = new WorkingExperience()
            {
                Id = workingExpDto.Id,
                EmployeeId = workingExpDto.EmployeeId,
                Name = workingExpDto.Name,
                Details = workingExpDto.Details,
                Environment = workingExpDto.Environment,
                StartDate = workingExpDto.StartDate,
                EndDate = workingExpDto.EndDate,
            };
            return workingExp;
        }
        public WorkingExperienceDto MapUp(WorkingExperience workingExp)
        {
            var workingExpDto = new WorkingExperienceDto()
            {
                Id = workingExp.Id,
                EmployeeId = workingExp.EmployeeId,
                Name = workingExp.Name,
                Details = workingExp.Details,
                Environment = workingExp.Environment,
                StartDate = workingExp.StartDate,
                EndDate = workingExp.EndDate,
            };
            return workingExpDto;
        }
    }
}
