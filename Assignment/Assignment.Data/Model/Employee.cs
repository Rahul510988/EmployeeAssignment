using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }

        public  ICollection<EmployeeAddress> EmployeeAddresses { get; set; }
        public ICollection<EmployeePhone> EmployeePhones { get; set; }
    }
}
