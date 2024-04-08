using Assignment.Data.Model;
using Assignment.Mappers;
using Assignment.Models;
using System.Runtime.InteropServices;

namespace Assignment.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IEmployeeMapper _employeeMapper;

        public IList<Employee> _employees { get; set; } = new List<Employee>();

        public EmployeeRepository(IEmployeeMapper employeeMapper ) { 
            _employeeMapper = employeeMapper;

            _employees.Add(CreateEmployeeData("12345","123-456-785"));
            _employees.Add(CreateEmployeeData("12346", "123-456-786"));
            _employees.Add(CreateEmployeeData("12347", "123-456-787"));
            _employees.Add(CreateEmployeeData("12348", "123-456-788"));
            _employees.Add(CreateEmployeeData("12349", "123-456-789"));
        }

        public async Task<IEnumerable<EmployeeResponseDto>> GetAll()
        {
            return await Task.FromResult(_employeeMapper.convert(_employees));
        }


        private static int _LastId = 0;
        private Employee CreateEmployeeData(string zipcode, string phoneNumber)
        {
            var employeeAddress = new EmployeeAddress()
            {
                Address1 = "123 st",
                Address2 = "Apt 201",
                City = "Dallas",
                State = "Texas",
                ZipCode = zipcode
            };

            var employeePhone1 = new EmployeePhone()
            {
                PhoneNumber = phoneNumber,
                PhoneType = "Cell"
            };

            var employeePhone2 = new EmployeePhone()
            {
                PhoneNumber = "233-456-7890",
                PhoneType = "Home"
            };

            var employee = new Employee()
            {
                EmployeeId = ++_LastId,
                EmployeeNumber = 13553 + _LastId,
                FirstName = $"John {_LastId}" ,
                LastName = $"Smith {_LastId}",
                HireDate = DateTime.Now.AddDays(-10),
                EmployeeAddresses = new List<EmployeeAddress>() { employeeAddress },
                EmployeePhones = new List<EmployeePhone>() { employeePhone1,employeePhone2 }
            };
             return employee;
        }
    }
}
