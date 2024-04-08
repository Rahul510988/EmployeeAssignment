using Assignment.Models;
using Assignment.Repository;

namespace Assignment.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeResponseDto>> GetAll()
        {
            return await _employeeRepository.GetAll();
        }
    }
}
