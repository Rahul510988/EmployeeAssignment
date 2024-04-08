using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Model
{
    public class EmployeePhone
    {
        public int EmployeePhoneId { get; set; }
        public int EmployeeId { get; set; }
        public string PhoneNumber { get; set;}
        public string PhoneType { get; set;}

        public Employee Employee { get;}

    }
}
