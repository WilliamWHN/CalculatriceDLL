using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorDLL
{
    [TestClass]
    public class CalculatorDLL
    {
        [TestMethod]
        public void add()
        {
            Calculatrice.Calculator CalculatorDLL = new Calculatrice.Calculator();

            float resExepcted = 4;
            float resActual = 0;

            resActual = CalculatorDLL.Add(1, 3);        

            Assert.AreEqual(resExepcted, resActual);
        }
    }
}
