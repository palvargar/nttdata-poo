using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.InterfaceExample
{
    public class Coche : IVehiculo, ICloneable
    {
        public void Arrancar()
        {
            Console.WriteLine("Arrancar coche");
        }

        public object Clone()
        {
            return new Coche();
        }

        public void Parar()
        {
            Console.WriteLine("Parar coche");
        }
    }
}
