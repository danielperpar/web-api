using Domain.DbFirst.Entities.Repository;

namespace Domain.DbFirst.Entities.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IEmployeeRepository EmployeeRepository { get; }

        public Task<int> SaveAsync();
    }
}
