using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Model
{
    public class EmployeeAddress
    {
        public int EmployeeAddressId { get; set; }
        public int EmployeeId { get; set; }
        public string Address1 { get; set; }
        public string Address2{ get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Employee Employee { get; }
    }
}
