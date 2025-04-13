using DbFirst.Entities;
using Domain.DbFirst.Entities;
using Domain.DbFirst.Entities.Repository;
using Microsoft.EntityFrameworkCore;

namespace DbFirst.Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DbFirstCursoEFContext _dbFirstCursoEFContext;

        public EmployeeRepository(DbFirstCursoEFContext dbFirstCursoEFContext)
        {
            _dbFirstCursoEFContext = dbFirstCursoEFContext;
        }

        public void Add(Employee user)
        {
           _dbFirstCursoEFContext.Employees.Add(user);
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _dbFirstCursoEFContext.Employees.ToListAsync();
        }
    }
}
