using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class NttDataBase
    {
        private Guid guid;
        public Guid Guid { get { return guid; } }

        public NttDataBase() { 
            guid= Guid.NewGuid();
        }
    }
}
