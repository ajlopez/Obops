namespace Obops.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
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
        public void AddShorts()
        {
            Assert.AreEqual(3, Operators.AddObject((short)1, (short)2));
            Assert.AreEqual(-1, Operators.AddObject((short)1, (short)-2));
            Assert.AreEqual(0, Operators.AddObject((short)0, (short)0));
        }

        [TestMethod]
        public void AddDoubles()
        {
            Assert.AreEqual(4.6, Operators.AddObject(1.2, 3.4));
            Assert.AreEqual(-1.0, Operators.AddObject(1.0, -2.0));
            Assert.AreEqual(0.0, Operators.AddObject(0.0, 0.0));
        }

        [TestMethod]
        public void AddIntegerToLong()
        {
            Assert.AreEqual((long)3, Operators.AddObject(1, (long)2));
            Assert.AreEqual((long)-1, Operators.AddObject(1, (long)-2));
            Assert.AreEqual((long)0, Operators.AddObject(0, (long)0));
            Assert.AreEqual(long.MaxValue, Operators.AddObject(0, (long)long.MaxValue));
        }

        [TestMethod]
        public void AddIntegerToDouble()
        {
            Assert.AreEqual(4.4, Operators.AddObject(1, 3.4));
            Assert.AreEqual(-1.0, Operators.AddObject(1, -2.0));
            Assert.AreEqual(0.0, Operators.AddObject(0, 0.0));
        }

        [TestMethod]
        public void AddDoubleToInteger()
        {
            Assert.AreEqual(4.4, Operators.AddObject(3.4, 1));
            Assert.AreEqual(-1.0, Operators.AddObject(-2.0, 1));
            Assert.AreEqual(0.0, Operators.AddObject(0.0, 0));
        }

        [TestMethod]
        public void AddDoubleToLong()
        {
            Assert.AreEqual(4.4, Operators.AddObject(3.4, (long)1));
            Assert.AreEqual(-1.0, Operators.AddObject(-2.0, (long)1));
            Assert.AreEqual(0.0, Operators.AddObject(0.0, (long)0));
        }
    }
}
