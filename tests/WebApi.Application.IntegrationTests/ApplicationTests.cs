using Application;
using DbFirst.Infrastructure.DbFirst;
using DbFirst.Infrastructure.Repository;
using Domain.DbFirst.Entities;
using FluentAssertions;

namespace WebApi.Application.IntegrationTests
{
    public class ApplicationTests
    {
        [Fact]
        public async Task GetAllEmployees_When_EmployeeExist_Returns_AllEmployees()
        {
            //Arrange
            var dbContext = TestUtils.GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);
            var uow = new UnitOfWork(employeeRepository, dbContext);
           
            var employees = new List<Employee>();
            employees.Add(new Employee
            {
                EmployeeName = "Jane Smith",
                WorkingExperiences = new List<WorkingExperience>
                {
                    new WorkingExperience
                    {
                        Name = "Project Manager",
                        Environment = "Management",
                        Details = "Managed multiple projects",
                        StartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-5)),
                        EndDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-1))
                    }
                }
            });

            employees.Add(new Employee
            {
                EmployeeName = "John Doe",
                WorkingExperiences = new List<WorkingExperience>
                {
                    new WorkingExperience
                    {
                        Name = "Software Engineer",
                        Environment = "Development",
                        Details = "Worked on various projects",
                        StartDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-2)),
                        EndDate = DateOnly.FromDateTime(DateTime.Now)
                    }
                }
            });

            employees.ForEach(e => employeeRepository.Add(e));
            dbContext.SaveChanges();

            var sut = new HumanResourcesService(uow);

            //Act
            var result = await sut.GetAllEmployees();

            //Assert
            result.Should().NotBeNull();
            result.Should().HaveCount(2);
            result.Should().BeEquivalentTo(employees);
        }
    }
}