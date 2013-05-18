namespace Obops.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OperatorsTests
    {
        [TestMethod]
        public void AddIntegers()
        {
            Assert.AreEqual(3, Operators.AddObject(1, 2));
            Assert.AreEqual(-1, Operators.AddObject(1, -2));
            Assert.AreEqual(0, Operators.AddObject(0, 0));
        }

        [TestMethod]
        public void AddDoubles()
        {
            Assert.AreEqual(4.6, Operators.AddObject(1.2, 3.4));
            Assert.AreEqual(-1.0, Operators.AddObject(1.0, -2.0));
            Assert.AreEqual(0.0, Operators.AddObject(0.0, 0.0));
        }
    }
}
