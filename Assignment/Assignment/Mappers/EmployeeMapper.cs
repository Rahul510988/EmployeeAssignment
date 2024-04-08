using Assignment.Data.Model;
using Assignment.Models;

namespace Assignment.Mappers
{
    // the other option is to use AutoMapper here
    public class EmployeeMapper : IEmployeeMapper
    {
        public IEnumerable<EmployeeResponseDto> convert(IEnumerable<Employee> employees)
        {
            var resultEmployee = new List<EmployeeResponseDto>();
            foreach (var employee in employees)
            {
                var emp = new EmployeeResponseDto();
                emp.EmployeeNumber = employee.EmployeeNumber;
                emp.EmployeeId = employee.EmployeeId;
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.HireDate = employee.HireDate;

                emp.EmployeeAddress=new List<EmployeeAddressResponseDto>();

                foreach(var employeeAddress in employee.EmployeeAddresses)
                {
                    var eAdd = new EmployeeAddressResponseDto();
                    eAdd.Address1 = employeeAddress.Address1;
                    eAdd.Address2 = employeeAddress.Address2;   
                    eAdd.City = employeeAddress.City;
                    eAdd.State = employeeAddress.State;
                    eAdd.ZipCode = employeeAddress.ZipCode;

                    emp.EmployeeAddress.Add(eAdd);
                }

                emp.EmployeePhone = new List<EmployeePhoneResponseDto>();

                foreach (var employeePhone in employee.EmployeePhones)
                {
                    var ePhone = new EmployeePhoneResponseDto();

                    ePhone.PhoneType= employeePhone.PhoneType;
                    ePhone.PhoneNumber = employeePhone.PhoneNumber;

                    emp.EmployeePhone.Add(ePhone);
                }

                resultEmployee.Add(emp);
            }


            return resultEmployee;
        }
    }
}
