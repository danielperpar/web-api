using Domain.DbFirst.Entities;
using Domain.DbFirst.Entities.UnitOfWork;

namespace Application
{
    public class HumanResourcesService : IHumanResourcesService
    {
        private readonly IUnitOfWork _unitOfWork;
        public HumanResourcesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateEmployee(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Add(employee);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _unitOfWork.EmployeeRepository.GetAllAsync();
        }
    }
}
