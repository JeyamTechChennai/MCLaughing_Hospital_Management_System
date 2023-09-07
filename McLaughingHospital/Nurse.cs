using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McLaughingHospital
{
    class Nurse : Employee
    {
        public double Salary { get; set; }

        public Nurse(string fn, string sn, string address, string county, int age, string phone, string email, int empNum, string position, double salary)
            : base(fn, sn, address, county, age, phone, email, empNum, position)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Salary: {Salary}");
            return sb.ToString();
        }
    }
}
