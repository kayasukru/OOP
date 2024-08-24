using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ADONET_DAL.Entities
{
    public class Employee
    {
        public int? EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public override string ToString()
        {
            return $"{EmployeeID,-5} {FirstName,-15} {LastName,-15}";
        }
    }
}
