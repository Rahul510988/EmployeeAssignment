using Assignment.Data.Model;
using Assignment.Models;

namespace Assignment.Mappers
{
    public interface IEmployeeMapper
    {
        IEnumerable<EmployeeResponseDto> convert(IEnumerable<Employee> employee);
    }
}