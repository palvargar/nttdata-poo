using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.PlanDePensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlanDePensiones.Tests
{
    [TestClass()]
    public class CalculoTests
    {
        [DataRow(12000f, 1000f, 2000f, 570f)]
        [DataRow(15000f, 1000f, 4000f, 1200f)]
        [DataRow(25000f, 1000f, 6000f, 2100f)]
        [DataRow(50000f, 1500f, 8000f, 3515f)]
        [DataRow(70000f, 1500f, 8500f, 4500f)]
        [DataRow(600000f, 10000f, 75000f, 39950f)]
        [TestMethod()]
        public void CalcularEspanaTest(float num1, float num2, float num3, float result)
        {
            var plan = new PlanDePensiones(num1, num2, num3);
            Assert.IsTrue(Calculo.CalcularEspana(plan) == result);
        }

        [DataRow(12000f, 1000f, 2000f, 0f)]
        [DataRow(25000f, 1000f, 6000f, 350f)]
        [DataRow(45000f, 1500f, 7000f, 850f)]
        [TestMethod()]
        public void CalcularAndorraTest(float num1, float num2, float num3, float result)
        {
            var plan = new PlanDePensiones(num1, num2, num3);
            Assert.IsTrue(Calculo.CalcularAndorra(plan) == result);
        }
    }
}