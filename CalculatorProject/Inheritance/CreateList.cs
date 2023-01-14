using CalculatorProject.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class CreateList
    {
        public static List<Student> CrearLista(List<Student> Students)
        {
            IEnumerable<Student> StudentQuery = from student in Students
                                                where (student.Age > 30)
                                                && (student.Name.ToCharArray()[0] == 'S')
                                                && (student.Address.City.Equals("Madrid"))
                                                select student;

            return StudentQuery.ToList();
        }
    }
}
