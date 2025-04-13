namespace Domain.DbFirst.Entities.Repository
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        Task<IEnumerable<Employee>> GetAllAsync();

    }
}
