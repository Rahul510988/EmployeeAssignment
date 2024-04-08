using Assignment.Data.Model;

namespace Assignment.Models
{
    public class EmployeeResponseDto
    {
        public int EmployeeId { get; set; }
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }

        public IList<EmployeeAddressResponseDto> EmployeeAddress { get; set;}

        public IList<EmployeePhoneResponseDto> EmployeePhone { get; set; }


    }

    public class EmployeeAddressResponseDto
    {
        public int EmployeeAddressId { get; set; }
        public int EmployeeId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

    public class EmployeePhoneResponseDto
    {
        public int EmployeePhoneId { get; set; }
        public int EmployeeId { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneType { get; set; }
    }

}
