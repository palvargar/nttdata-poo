using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class Address:NttDataBase
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        public Address(string street, string city, string region)
        {
            Guid Guid = base.Guid;
            Street = street;
            City = city;
            Region = region;
        }
    }
}
