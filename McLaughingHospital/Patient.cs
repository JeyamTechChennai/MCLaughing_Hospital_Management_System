using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McLaughingHospital
{
    class Patient : Person
    {
        public int PatientNumber { get; set; }
        public Patient(string fn, string sn, string address, string county, int age, string phone, string email, int patNo)
            : base(fn, sn, address, county, age, phone, email)
        {
            PatientNumber = patNo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Patient Number: {PatientNumber}");
            return sb.ToString();
        }
    }
}
