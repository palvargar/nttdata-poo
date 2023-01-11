using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops.Tests
{
    [TestClass()]
    public class PrintProductTests
    {
        PrintProduct a = new PrintProduct();

        /*public static void ClassInicialize(TestContext context)
        {
            PrintProduct.CreateListProduct();
        }*/

        [TestMethod()]
        public void GetProductsGreaterThan30WithForTest()
        {
            List<Product> products = a.GetProductsGreaterThan30WithFor();
            Assert.IsTrue(products.Count == 2 && products[0].Name.Equals("Aceite") && products[1].Name.Equals("Juego")); 
        }

        [TestMethod()]
        public void GetProductsGreaterThan30WithForEachTest()
        {
            List<Product> products = a.GetProductsGreaterThan30WithFor();
            Assert.IsTrue(products.Count == 2 && products[0].Name.Equals("Aceite") && products[1].Name.Equals("Juego"));
        }

        [TestMethod()]
        public void GetProductsGreaterThan30WithWhileTest()
        {
            List<Product> products = a.GetProductsGreaterThan30WithFor();
            Assert.IsTrue(products.Count == 2 && products[0].Name.Equals("Aceite") && products[1].Name.Equals("Juego"));
        }

        [TestMethod()]
        public void GetProductsGreaterThan30WithLinqTest()
        {
            List<Product> products = a.GetProductsGreaterThan30WithFor();
            Assert.IsTrue(products.Count == 2 && products[0].Name.Equals("Aceite") && products[1].Name.Equals("Juego"));
        }
    }
}