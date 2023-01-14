using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance.Tests
{
    [TestClass()]
    public class CreateListTests
    {
        [TestMethod()]
        public void CrearListaTest()
        {
            List<Student> students = new List<Student>();
            Student Estudiante1 = new Student("Xavier", "Goñi", DateTime.Parse("2005 / 4 / 3"), new Address("Adoracion", "Cuenca", "Castilla-La Mancha"));
            Student Estudiante2 = new Student("Sergio", "Magano", DateTime.Parse("1999 / 2 / 7"), new Address("Gómez de Salazar", "Madrid", "Comunidad de Madrid"));
            Student Estudiante3 = new Student("Gilberto", "Perez", DateTime.Parse("1978 / 7 / 25"), new Address("Distrito Capital", "Caceres", "Extremadura"));
            Student Estudiante4 = new Student("Ulises ", "Garcia", DateTime.Parse("1998 / 4 / 18"), new Address("Real del Asemota", "Madrid", "Comunidad de Madrid"));
            Student Estudiante5 = new Student("Samanta", "Zarabozo", DateTime.Parse("1990 / 6 / 1"), new Address("Simiente", "Madrid", "Comunidad de Madrid"));

            students.Add(Estudiante1);
            students.Add(Estudiante2);
            students.Add(Estudiante3);
            students.Add(Estudiante4);
            students.Add(Estudiante5);

            Assert.IsTrue(((CreateList.CrearLista(students)).Count == 1));
        }
    }
}