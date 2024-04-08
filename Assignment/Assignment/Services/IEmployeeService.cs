using Assignment.Models;

namespace Assignment.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeResponseDto>> GetAll();
    }
}