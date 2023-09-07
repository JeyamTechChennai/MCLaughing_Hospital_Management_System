using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McLaughingHospital
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        
        public string Address { get; set; }
        public string County { get; set; }

        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Person(string fn, string sn, string address, string county, int age, string phone, string email)
        {
            FirstName = fn;
            Surname = sn;
            Address = address;
            County = county;
            Age = age;
            Phone = phone;
            Email = email;
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{FirstName} {Surname}, {Age} years old, Address: {Address}, {County}, Phone: {Phone}, Email {Email}, ");
            return sb.ToString();
        }

    }
}
