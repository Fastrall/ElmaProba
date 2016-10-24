using System;
using Calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            var calc = new Calculator();
            var result = calc.Sum(2, 3);
           Assert.IsTrue(result == 5);
        }

        [TestMethod]
        public void TestDivide()
        {
            var calc = new Calculator();

            Assert.IsTrue(calc.Divide(6, 2) == 3);

            Assert.IsTrue(calc.Divide(0, 2) == 0);

            Assert.IsNull(calc.Divide(6, 0));
        }

        [TestMethod]
        public void TestDiffer()
        {
            var calc = new Calculator();

            Assert.IsTrue(calc.Differ(2, 3) == -1);
        }

        [TestMethod]
        public void TestMultiple()
        {
            var calc = new Calculator();

            Assert.IsTrue(calc.Multiple(2, 3) == 6);
        }

        [TestMethod]
        public void TestStepen()
        {
            var calc = new Calculator();

            Assert.IsTrue(calc.Stepen(2, 3) == 8);
        }

        [TestMethod]
        public void TestKoren()
        {
            var calc = new Calculator();

            Assert.IsTrue(calc.Koren(8, 3) == 2);
        }

        [TestMethod]
        public void TestOstatok()
        {
            var calc = new Calculator();

            Assert.IsTrue(calc.Ostatok(2, 3) == 2);
        }
    }
}
