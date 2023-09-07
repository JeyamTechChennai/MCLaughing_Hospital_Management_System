using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McLaughingHospital
{
   public abstract class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public string Position { get; set; }

        public Employee (string fn, string sn, string address, string county, int age, string phone, string email, int empNum, string position)
            : base(fn, sn, address, county, age, phone, email)
        {
            EmployeeNumber = empNum;
            Position = position;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Employee Number: {EmployeeNumber}, Position {Position}, ");
            return sb.ToString();
        }
    }
}
