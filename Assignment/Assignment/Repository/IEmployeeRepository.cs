using Assignment.Models;

namespace Assignment.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeResponseDto>> GetAll();
    }
}