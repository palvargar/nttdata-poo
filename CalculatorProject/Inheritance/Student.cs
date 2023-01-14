using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class Student:NttDataBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public Address Address { get; set; }
        public int Age { get; set; }

        public Student(string name, string surname, DateTime birthday, Address address)
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
            this.Address = address;
            this.Age = CalcularEdad();
        }
        public int CalcularEdad()
        {
            var Ahora = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            var Nacimiento = new DateTime(Birthday.Year, Birthday.Month, Birthday.Day);
            var edad = ((Ahora - Nacimiento).Days / 365);
            return edad;
        }
    }
}