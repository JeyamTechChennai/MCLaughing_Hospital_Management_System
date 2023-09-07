using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McLaughingHospital
{
    class Doctor : Employee
    {
        public string  Specialty { get; set; }

        public Doctor (string fn, string sn, string address, string county, int age, string phone, string email, int empNum, string position, string specialty)
            : base(fn, sn, address, county, age, phone, email, empNum, position)
        {
            Specialty = specialty;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Specialty: {Specialty}");
            return sb.ToString();
        }
    }
}
