﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();
        [TestMethod()]
        public void AddTest()
        {
            Assert.IsTrue(calculator.Add(2, 2) == 4);
            Assert.IsFalse(calculator.Add(2, 2) == 5);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Assert.IsTrue(calculator.Substract(4, 2) == 2);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.IsTrue(calculator.Multiply(2, 4) == 8);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.IsTrue(calculator.Divide(8, 2) == 4);
        }
    }
}