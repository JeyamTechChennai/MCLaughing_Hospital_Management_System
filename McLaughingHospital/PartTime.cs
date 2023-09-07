using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McLaughingHospital
{
    class PartTime : Employee
    {
        public int NumberOfHours { get; set; }


        public PartTime(string fn, string sn, string address, string county, int age, string phone, string email, int empNum, string position, int numberOfHours)
            : base(fn, sn, address, county, age, phone, email, empNum, position)
        {
            NumberOfHours = numberOfHours;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Number of Hours: {NumberOfHours}");
            return sb.ToString();
        }
    }
}
