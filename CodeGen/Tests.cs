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
        public void AddShortShort()
        {
            Assert.AreEqual((short)1 + (short)1, Operators.AddObject((short)1, (short)1));
            Assert.AreEqual((short)1 + (short)2, Operators.AddObject((short)1, (short)2));
            Assert.AreEqual((short)2 + (short)1, Operators.AddObject((short)2, (short)1));
            Assert.AreEqual((short)2 + (short)2, Operators.AddObject((short)2, (short)2));
        }
        
        [TestMethod]
        public void AddShortInteger()
        {
            Assert.AreEqual((short)1 + (int)1, Operators.AddObject((short)1, (int)1));
            Assert.AreEqual((short)1 + (int)2, Operators.AddObject((short)1, (int)2));
            Assert.AreEqual((short)2 + (int)1, Operators.AddObject((short)2, (int)1));
            Assert.AreEqual((short)2 + (int)2, Operators.AddObject((short)2, (int)2));
        }
        
        [TestMethod]
        public void AddShortLong()
        {
            Assert.AreEqual((short)1 + (long)1, Operators.AddObject((short)1, (long)1));
            Assert.AreEqual((short)1 + (long)2, Operators.AddObject((short)1, (long)2));
            Assert.AreEqual((short)2 + (long)1, Operators.AddObject((short)2, (long)1));
            Assert.AreEqual((short)2 + (long)2, Operators.AddObject((short)2, (long)2));
        }
        
        [TestMethod]
        public void AddShortFloat()
        {
            Assert.AreEqual((short)1 + (float)1.2, Operators.AddObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 + (float)2.3, Operators.AddObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 + (float)1.2, Operators.AddObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 + (float)2.3, Operators.AddObject((short)2, (float)2.3));
        }
        
        [TestMethod]
        public void AddShortDouble()
        {
            Assert.AreEqual((short)1 + (double)1.2, Operators.AddObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 + (double)2.3, Operators.AddObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 + (double)1.2, Operators.AddObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 + (double)2.3, Operators.AddObject((short)2, (double)2.3));
        }
        
        [TestMethod]
        public void AddIntegerShort()
        {
            Assert.AreEqual((int)1 + (short)1, Operators.AddObject((int)1, (short)1));
            Assert.AreEqual((int)1 + (short)2, Operators.AddObject((int)1, (short)2));
            Assert.AreEqual((int)2 + (short)1, Operators.AddObject((int)2, (short)1));
            Assert.AreEqual((int)2 + (short)2, Operators.AddObject((int)2, (short)2));
        }
        
        [TestMethod]
        public void AddIntegerInteger()
        {
            Assert.AreEqual((int)1 + (int)1, Operators.AddObject((int)1, (int)1));
            Assert.AreEqual((int)1 + (int)2, Operators.AddObject((int)1, (int)2));
            Assert.AreEqual((int)2 + (int)1, Operators.AddObject((int)2, (int)1));
            Assert.AreEqual((int)2 + (int)2, Operators.AddObject((int)2, (int)2));
        }
        
        [TestMethod]
        public void AddIntegerLong()
        {
            Assert.AreEqual((int)1 + (long)1, Operators.AddObject((int)1, (long)1));
            Assert.AreEqual((int)1 + (long)2, Operators.AddObject((int)1, (long)2));
            Assert.AreEqual((int)2 + (long)1, Operators.AddObject((int)2, (long)1));
            Assert.AreEqual((int)2 + (long)2, Operators.AddObject((int)2, (long)2));
        }
        
        [TestMethod]
        public void AddIntegerFloat()
        {
            Assert.AreEqual((int)1 + (float)1.2, Operators.AddObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 + (float)2.3, Operators.AddObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 + (float)1.2, Operators.AddObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 + (float)2.3, Operators.AddObject((int)2, (float)2.3));
        }
        
        [TestMethod]
        public void AddIntegerDouble()
        {
            Assert.AreEqual((int)1 + (double)1.2, Operators.AddObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 + (double)2.3, Operators.AddObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 + (double)1.2, Operators.AddObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 + (double)2.3, Operators.AddObject((int)2, (double)2.3));
        }
        
        [TestMethod]
        public void AddLongShort()
        {
            Assert.AreEqual((long)1 + (short)1, Operators.AddObject((long)1, (short)1));
            Assert.AreEqual((long)1 + (short)2, Operators.AddObject((long)1, (short)2));
            Assert.AreEqual((long)2 + (short)1, Operators.AddObject((long)2, (short)1));
            Assert.AreEqual((long)2 + (short)2, Operators.AddObject((long)2, (short)2));
        }
        
        [TestMethod]
        public void AddLongInteger()
        {
            Assert.AreEqual((long)1 + (int)1, Operators.AddObject((long)1, (int)1));
            Assert.AreEqual((long)1 + (int)2, Operators.AddObject((long)1, (int)2));
            Assert.AreEqual((long)2 + (int)1, Operators.AddObject((long)2, (int)1));
            Assert.AreEqual((long)2 + (int)2, Operators.AddObject((long)2, (int)2));
        }
        
        [TestMethod]
        public void AddLongLong()
        {
            Assert.AreEqual((long)1 + (long)1, Operators.AddObject((long)1, (long)1));
            Assert.AreEqual((long)1 + (long)2, Operators.AddObject((long)1, (long)2));
            Assert.AreEqual((long)2 + (long)1, Operators.AddObject((long)2, (long)1));
            Assert.AreEqual((long)2 + (long)2, Operators.AddObject((long)2, (long)2));
        }
        
        [TestMethod]
        public void AddLongFloat()
        {
            Assert.AreEqual((long)1 + (float)1.2, Operators.AddObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 + (float)2.3, Operators.AddObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 + (float)1.2, Operators.AddObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 + (float)2.3, Operators.AddObject((long)2, (float)2.3));
        }
        
        [TestMethod]
        public void AddLongDouble()
        {
            Assert.AreEqual((long)1 + (double)1.2, Operators.AddObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 + (double)2.3, Operators.AddObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 + (double)1.2, Operators.AddObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 + (double)2.3, Operators.AddObject((long)2, (double)2.3));
        }
        
        [TestMethod]
        public void AddFloatShort()
        {
            Assert.AreEqual((float)1.2 + (short)1, Operators.AddObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 + (short)2, Operators.AddObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 + (short)1, Operators.AddObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 + (short)2, Operators.AddObject((float)2.3, (short)2));
        }
        
        [TestMethod]
        public void AddFloatInteger()
        {
            Assert.AreEqual((float)1.2 + (int)1, Operators.AddObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 + (int)2, Operators.AddObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 + (int)1, Operators.AddObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 + (int)2, Operators.AddObject((float)2.3, (int)2));
        }
        
        [TestMethod]
        public void AddFloatLong()
        {
            Assert.AreEqual((float)1.2 + (long)1, Operators.AddObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 + (long)2, Operators.AddObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 + (long)1, Operators.AddObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 + (long)2, Operators.AddObject((float)2.3, (long)2));
        }
        
        [TestMethod]
        public void AddFloatFloat()
        {
            Assert.AreEqual((float)1.2 + (float)1.2, Operators.AddObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 + (float)2.3, Operators.AddObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 + (float)1.2, Operators.AddObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 + (float)2.3, Operators.AddObject((float)2.3, (float)2.3));
        }
        
        [TestMethod]
        public void AddFloatDouble()
        {
            Assert.AreEqual((float)1.2 + (double)1.2, Operators.AddObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 + (double)2.3, Operators.AddObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 + (double)1.2, Operators.AddObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 + (double)2.3, Operators.AddObject((float)2.3, (double)2.3));
        }
        
        [TestMethod]
        public void AddDoubleShort()
        {
            Assert.AreEqual((double)1.2 + (short)1, Operators.AddObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 + (short)2, Operators.AddObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 + (short)1, Operators.AddObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 + (short)2, Operators.AddObject((double)2.3, (short)2));
        }
        
        [TestMethod]
        public void AddDoubleInteger()
        {
            Assert.AreEqual((double)1.2 + (int)1, Operators.AddObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 + (int)2, Operators.AddObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 + (int)1, Operators.AddObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 + (int)2, Operators.AddObject((double)2.3, (int)2));
        }
        
        [TestMethod]
        public void AddDoubleLong()
        {
            Assert.AreEqual((double)1.2 + (long)1, Operators.AddObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 + (long)2, Operators.AddObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 + (long)1, Operators.AddObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 + (long)2, Operators.AddObject((double)2.3, (long)2));
        }
        
        [TestMethod]
        public void AddDoubleFloat()
        {
            Assert.AreEqual((double)1.2 + (float)1.2, Operators.AddObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 + (float)2.3, Operators.AddObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 + (float)1.2, Operators.AddObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 + (float)2.3, Operators.AddObject((double)2.3, (float)2.3));
        }
        
        [TestMethod]
        public void AddDoubleDouble()
        {
            Assert.AreEqual((double)1.2 + (double)1.2, Operators.AddObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 + (double)2.3, Operators.AddObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 + (double)1.2, Operators.AddObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 + (double)2.3, Operators.AddObject((double)2.3, (double)2.3));
        }
        
        [TestMethod]
        public void SubtractShortShort()
        {
            Assert.AreEqual((short)1 - (short)1, Operators.SubtractObject((short)1, (short)1));
            Assert.AreEqual((short)1 - (short)2, Operators.SubtractObject((short)1, (short)2));
            Assert.AreEqual((short)2 - (short)1, Operators.SubtractObject((short)2, (short)1));
            Assert.AreEqual((short)2 - (short)2, Operators.SubtractObject((short)2, (short)2));
        }
        
        [TestMethod]
        public void SubtractShortInteger()
        {
            Assert.AreEqual((short)1 - (int)1, Operators.SubtractObject((short)1, (int)1));
            Assert.AreEqual((short)1 - (int)2, Operators.SubtractObject((short)1, (int)2));
            Assert.AreEqual((short)2 - (int)1, Operators.SubtractObject((short)2, (int)1));
            Assert.AreEqual((short)2 - (int)2, Operators.SubtractObject((short)2, (int)2));
        }
        
        [TestMethod]
        public void SubtractShortLong()
        {
            Assert.AreEqual((short)1 - (long)1, Operators.SubtractObject((short)1, (long)1));
            Assert.AreEqual((short)1 - (long)2, Operators.SubtractObject((short)1, (long)2));
            Assert.AreEqual((short)2 - (long)1, Operators.SubtractObject((short)2, (long)1));
            Assert.AreEqual((short)2 - (long)2, Operators.SubtractObject((short)2, (long)2));
        }
        
        [TestMethod]
        public void SubtractShortFloat()
        {
            Assert.AreEqual((short)1 - (float)1.2, Operators.SubtractObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 - (float)2.3, Operators.SubtractObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 - (float)1.2, Operators.SubtractObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 - (float)2.3, Operators.SubtractObject((short)2, (float)2.3));
        }
        
        [TestMethod]
        public void SubtractShortDouble()
        {
            Assert.AreEqual((short)1 - (double)1.2, Operators.SubtractObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 - (double)2.3, Operators.SubtractObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 - (double)1.2, Operators.SubtractObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 - (double)2.3, Operators.SubtractObject((short)2, (double)2.3));
        }
        
        [TestMethod]
        public void SubtractIntegerShort()
        {
            Assert.AreEqual((int)1 - (short)1, Operators.SubtractObject((int)1, (short)1));
            Assert.AreEqual((int)1 - (short)2, Operators.SubtractObject((int)1, (short)2));
            Assert.AreEqual((int)2 - (short)1, Operators.SubtractObject((int)2, (short)1));
            Assert.AreEqual((int)2 - (short)2, Operators.SubtractObject((int)2, (short)2));
        }
        
        [TestMethod]
        public void SubtractIntegerInteger()
        {
            Assert.AreEqual((int)1 - (int)1, Operators.SubtractObject((int)1, (int)1));
            Assert.AreEqual((int)1 - (int)2, Operators.SubtractObject((int)1, (int)2));
            Assert.AreEqual((int)2 - (int)1, Operators.SubtractObject((int)2, (int)1));
            Assert.AreEqual((int)2 - (int)2, Operators.SubtractObject((int)2, (int)2));
        }
        
        [TestMethod]
        public void SubtractIntegerLong()
        {
            Assert.AreEqual((int)1 - (long)1, Operators.SubtractObject((int)1, (long)1));
            Assert.AreEqual((int)1 - (long)2, Operators.SubtractObject((int)1, (long)2));
            Assert.AreEqual((int)2 - (long)1, Operators.SubtractObject((int)2, (long)1));
            Assert.AreEqual((int)2 - (long)2, Operators.SubtractObject((int)2, (long)2));
        }
        
        [TestMethod]
        public void SubtractIntegerFloat()
        {
            Assert.AreEqual((int)1 - (float)1.2, Operators.SubtractObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 - (float)2.3, Operators.SubtractObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 - (float)1.2, Operators.SubtractObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 - (float)2.3, Operators.SubtractObject((int)2, (float)2.3));
        }
        
        [TestMethod]
        public void SubtractIntegerDouble()
        {
            Assert.AreEqual((int)1 - (double)1.2, Operators.SubtractObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 - (double)2.3, Operators.SubtractObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 - (double)1.2, Operators.SubtractObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 - (double)2.3, Operators.SubtractObject((int)2, (double)2.3));
        }
        
        [TestMethod]
        public void SubtractLongShort()
        {
            Assert.AreEqual((long)1 - (short)1, Operators.SubtractObject((long)1, (short)1));
            Assert.AreEqual((long)1 - (short)2, Operators.SubtractObject((long)1, (short)2));
            Assert.AreEqual((long)2 - (short)1, Operators.SubtractObject((long)2, (short)1));
            Assert.AreEqual((long)2 - (short)2, Operators.SubtractObject((long)2, (short)2));
        }
        
        [TestMethod]
        public void SubtractLongInteger()
        {
            Assert.AreEqual((long)1 - (int)1, Operators.SubtractObject((long)1, (int)1));
            Assert.AreEqual((long)1 - (int)2, Operators.SubtractObject((long)1, (int)2));
            Assert.AreEqual((long)2 - (int)1, Operators.SubtractObject((long)2, (int)1));
            Assert.AreEqual((long)2 - (int)2, Operators.SubtractObject((long)2, (int)2));
        }
        
        [TestMethod]
        public void SubtractLongLong()
        {
            Assert.AreEqual((long)1 - (long)1, Operators.SubtractObject((long)1, (long)1));
            Assert.AreEqual((long)1 - (long)2, Operators.SubtractObject((long)1, (long)2));
            Assert.AreEqual((long)2 - (long)1, Operators.SubtractObject((long)2, (long)1));
            Assert.AreEqual((long)2 - (long)2, Operators.SubtractObject((long)2, (long)2));
        }
        
        [TestMethod]
        public void SubtractLongFloat()
        {
            Assert.AreEqual((long)1 - (float)1.2, Operators.SubtractObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 - (float)2.3, Operators.SubtractObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 - (float)1.2, Operators.SubtractObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 - (float)2.3, Operators.SubtractObject((long)2, (float)2.3));
        }
        
        [TestMethod]
        public void SubtractLongDouble()
        {
            Assert.AreEqual((long)1 - (double)1.2, Operators.SubtractObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 - (double)2.3, Operators.SubtractObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 - (double)1.2, Operators.SubtractObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 - (double)2.3, Operators.SubtractObject((long)2, (double)2.3));
        }
        
        [TestMethod]
        public void SubtractFloatShort()
        {
            Assert.AreEqual((float)1.2 - (short)1, Operators.SubtractObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 - (short)2, Operators.SubtractObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 - (short)1, Operators.SubtractObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 - (short)2, Operators.SubtractObject((float)2.3, (short)2));
        }
        
        [TestMethod]
        public void SubtractFloatInteger()
        {
            Assert.AreEqual((float)1.2 - (int)1, Operators.SubtractObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 - (int)2, Operators.SubtractObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 - (int)1, Operators.SubtractObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 - (int)2, Operators.SubtractObject((float)2.3, (int)2));
        }
        
        [TestMethod]
        public void SubtractFloatLong()
        {
            Assert.AreEqual((float)1.2 - (long)1, Operators.SubtractObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 - (long)2, Operators.SubtractObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 - (long)1, Operators.SubtractObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 - (long)2, Operators.SubtractObject((float)2.3, (long)2));
        }
        
        [TestMethod]
        public void SubtractFloatFloat()
        {
            Assert.AreEqual((float)1.2 - (float)1.2, Operators.SubtractObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 - (float)2.3, Operators.SubtractObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 - (float)1.2, Operators.SubtractObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 - (float)2.3, Operators.SubtractObject((float)2.3, (float)2.3));
        }
        
        [TestMethod]
        public void SubtractFloatDouble()
        {
            Assert.AreEqual((float)1.2 - (double)1.2, Operators.SubtractObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 - (double)2.3, Operators.SubtractObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 - (double)1.2, Operators.SubtractObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 - (double)2.3, Operators.SubtractObject((float)2.3, (double)2.3));
        }
        
        [TestMethod]
        public void SubtractDoubleShort()
        {
            Assert.AreEqual((double)1.2 - (short)1, Operators.SubtractObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 - (short)2, Operators.SubtractObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 - (short)1, Operators.SubtractObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 - (short)2, Operators.SubtractObject((double)2.3, (short)2));
        }
        
        [TestMethod]
        public void SubtractDoubleInteger()
        {
            Assert.AreEqual((double)1.2 - (int)1, Operators.SubtractObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 - (int)2, Operators.SubtractObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 - (int)1, Operators.SubtractObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 - (int)2, Operators.SubtractObject((double)2.3, (int)2));
        }
        
        [TestMethod]
        public void SubtractDoubleLong()
        {
            Assert.AreEqual((double)1.2 - (long)1, Operators.SubtractObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 - (long)2, Operators.SubtractObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 - (long)1, Operators.SubtractObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 - (long)2, Operators.SubtractObject((double)2.3, (long)2));
        }
        
        [TestMethod]
        public void SubtractDoubleFloat()
        {
            Assert.AreEqual((double)1.2 - (float)1.2, Operators.SubtractObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 - (float)2.3, Operators.SubtractObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 - (float)1.2, Operators.SubtractObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 - (float)2.3, Operators.SubtractObject((double)2.3, (float)2.3));
        }
        
        [TestMethod]
        public void SubtractDoubleDouble()
        {
            Assert.AreEqual((double)1.2 - (double)1.2, Operators.SubtractObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 - (double)2.3, Operators.SubtractObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 - (double)1.2, Operators.SubtractObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 - (double)2.3, Operators.SubtractObject((double)2.3, (double)2.3));
        }
        
        [TestMethod]
        public void MultiplyShortShort()
        {
            Assert.AreEqual((short)1 * (short)1, Operators.MultiplyObject((short)1, (short)1));
            Assert.AreEqual((short)1 * (short)2, Operators.MultiplyObject((short)1, (short)2));
            Assert.AreEqual((short)2 * (short)1, Operators.MultiplyObject((short)2, (short)1));
            Assert.AreEqual((short)2 * (short)2, Operators.MultiplyObject((short)2, (short)2));
        }
        
        [TestMethod]
        public void MultiplyShortInteger()
        {
            Assert.AreEqual((short)1 * (int)1, Operators.MultiplyObject((short)1, (int)1));
            Assert.AreEqual((short)1 * (int)2, Operators.MultiplyObject((short)1, (int)2));
            Assert.AreEqual((short)2 * (int)1, Operators.MultiplyObject((short)2, (int)1));
            Assert.AreEqual((short)2 * (int)2, Operators.MultiplyObject((short)2, (int)2));
        }
        
        [TestMethod]
        public void MultiplyShortLong()
        {
            Assert.AreEqual((short)1 * (long)1, Operators.MultiplyObject((short)1, (long)1));
            Assert.AreEqual((short)1 * (long)2, Operators.MultiplyObject((short)1, (long)2));
            Assert.AreEqual((short)2 * (long)1, Operators.MultiplyObject((short)2, (long)1));
            Assert.AreEqual((short)2 * (long)2, Operators.MultiplyObject((short)2, (long)2));
        }
        
        [TestMethod]
        public void MultiplyShortFloat()
        {
            Assert.AreEqual((short)1 * (float)1.2, Operators.MultiplyObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 * (float)2.3, Operators.MultiplyObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 * (float)1.2, Operators.MultiplyObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 * (float)2.3, Operators.MultiplyObject((short)2, (float)2.3));
        }
        
        [TestMethod]
        public void MultiplyShortDouble()
        {
            Assert.AreEqual((short)1 * (double)1.2, Operators.MultiplyObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 * (double)2.3, Operators.MultiplyObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 * (double)1.2, Operators.MultiplyObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 * (double)2.3, Operators.MultiplyObject((short)2, (double)2.3));
        }
        
        [TestMethod]
        public void MultiplyIntegerShort()
        {
            Assert.AreEqual((int)1 * (short)1, Operators.MultiplyObject((int)1, (short)1));
            Assert.AreEqual((int)1 * (short)2, Operators.MultiplyObject((int)1, (short)2));
            Assert.AreEqual((int)2 * (short)1, Operators.MultiplyObject((int)2, (short)1));
            Assert.AreEqual((int)2 * (short)2, Operators.MultiplyObject((int)2, (short)2));
        }
        
        [TestMethod]
        public void MultiplyIntegerInteger()
        {
            Assert.AreEqual((int)1 * (int)1, Operators.MultiplyObject((int)1, (int)1));
            Assert.AreEqual((int)1 * (int)2, Operators.MultiplyObject((int)1, (int)2));
            Assert.AreEqual((int)2 * (int)1, Operators.MultiplyObject((int)2, (int)1));
            Assert.AreEqual((int)2 * (int)2, Operators.MultiplyObject((int)2, (int)2));
        }
        
        [TestMethod]
        public void MultiplyIntegerLong()
        {
            Assert.AreEqual((int)1 * (long)1, Operators.MultiplyObject((int)1, (long)1));
            Assert.AreEqual((int)1 * (long)2, Operators.MultiplyObject((int)1, (long)2));
            Assert.AreEqual((int)2 * (long)1, Operators.MultiplyObject((int)2, (long)1));
            Assert.AreEqual((int)2 * (long)2, Operators.MultiplyObject((int)2, (long)2));
        }
        
        [TestMethod]
        public void MultiplyIntegerFloat()
        {
            Assert.AreEqual((int)1 * (float)1.2, Operators.MultiplyObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 * (float)2.3, Operators.MultiplyObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 * (float)1.2, Operators.MultiplyObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 * (float)2.3, Operators.MultiplyObject((int)2, (float)2.3));
        }
        
        [TestMethod]
        public void MultiplyIntegerDouble()
        {
            Assert.AreEqual((int)1 * (double)1.2, Operators.MultiplyObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 * (double)2.3, Operators.MultiplyObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 * (double)1.2, Operators.MultiplyObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 * (double)2.3, Operators.MultiplyObject((int)2, (double)2.3));
        }
        
        [TestMethod]
        public void MultiplyLongShort()
        {
            Assert.AreEqual((long)1 * (short)1, Operators.MultiplyObject((long)1, (short)1));
            Assert.AreEqual((long)1 * (short)2, Operators.MultiplyObject((long)1, (short)2));
            Assert.AreEqual((long)2 * (short)1, Operators.MultiplyObject((long)2, (short)1));
            Assert.AreEqual((long)2 * (short)2, Operators.MultiplyObject((long)2, (short)2));
        }
        
        [TestMethod]
        public void MultiplyLongInteger()
        {
            Assert.AreEqual((long)1 * (int)1, Operators.MultiplyObject((long)1, (int)1));
            Assert.AreEqual((long)1 * (int)2, Operators.MultiplyObject((long)1, (int)2));
            Assert.AreEqual((long)2 * (int)1, Operators.MultiplyObject((long)2, (int)1));
            Assert.AreEqual((long)2 * (int)2, Operators.MultiplyObject((long)2, (int)2));
        }
        
        [TestMethod]
        public void MultiplyLongLong()
        {
            Assert.AreEqual((long)1 * (long)1, Operators.MultiplyObject((long)1, (long)1));
            Assert.AreEqual((long)1 * (long)2, Operators.MultiplyObject((long)1, (long)2));
            Assert.AreEqual((long)2 * (long)1, Operators.MultiplyObject((long)2, (long)1));
            Assert.AreEqual((long)2 * (long)2, Operators.MultiplyObject((long)2, (long)2));
        }
        
        [TestMethod]
        public void MultiplyLongFloat()
        {
            Assert.AreEqual((long)1 * (float)1.2, Operators.MultiplyObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 * (float)2.3, Operators.MultiplyObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 * (float)1.2, Operators.MultiplyObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 * (float)2.3, Operators.MultiplyObject((long)2, (float)2.3));
        }
        
        [TestMethod]
        public void MultiplyLongDouble()
        {
            Assert.AreEqual((long)1 * (double)1.2, Operators.MultiplyObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 * (double)2.3, Operators.MultiplyObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 * (double)1.2, Operators.MultiplyObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 * (double)2.3, Operators.MultiplyObject((long)2, (double)2.3));
        }
        
        [TestMethod]
        public void MultiplyFloatShort()
        {
            Assert.AreEqual((float)1.2 * (short)1, Operators.MultiplyObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 * (short)2, Operators.MultiplyObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 * (short)1, Operators.MultiplyObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 * (short)2, Operators.MultiplyObject((float)2.3, (short)2));
        }
        
        [TestMethod]
        public void MultiplyFloatInteger()
        {
            Assert.AreEqual((float)1.2 * (int)1, Operators.MultiplyObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 * (int)2, Operators.MultiplyObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 * (int)1, Operators.MultiplyObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 * (int)2, Operators.MultiplyObject((float)2.3, (int)2));
        }
        
        [TestMethod]
        public void MultiplyFloatLong()
        {
            Assert.AreEqual((float)1.2 * (long)1, Operators.MultiplyObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 * (long)2, Operators.MultiplyObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 * (long)1, Operators.MultiplyObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 * (long)2, Operators.MultiplyObject((float)2.3, (long)2));
        }
        
        [TestMethod]
        public void MultiplyFloatFloat()
        {
            Assert.AreEqual((float)1.2 * (float)1.2, Operators.MultiplyObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 * (float)2.3, Operators.MultiplyObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 * (float)1.2, Operators.MultiplyObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 * (float)2.3, Operators.MultiplyObject((float)2.3, (float)2.3));
        }
        
        [TestMethod]
        public void MultiplyFloatDouble()
        {
            Assert.AreEqual((float)1.2 * (double)1.2, Operators.MultiplyObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 * (double)2.3, Operators.MultiplyObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 * (double)1.2, Operators.MultiplyObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 * (double)2.3, Operators.MultiplyObject((float)2.3, (double)2.3));
        }
        
        [TestMethod]
        public void MultiplyDoubleShort()
        {
            Assert.AreEqual((double)1.2 * (short)1, Operators.MultiplyObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 * (short)2, Operators.MultiplyObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 * (short)1, Operators.MultiplyObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 * (short)2, Operators.MultiplyObject((double)2.3, (short)2));
        }
        
        [TestMethod]
        public void MultiplyDoubleInteger()
        {
            Assert.AreEqual((double)1.2 * (int)1, Operators.MultiplyObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 * (int)2, Operators.MultiplyObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 * (int)1, Operators.MultiplyObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 * (int)2, Operators.MultiplyObject((double)2.3, (int)2));
        }
        
        [TestMethod]
        public void MultiplyDoubleLong()
        {
            Assert.AreEqual((double)1.2 * (long)1, Operators.MultiplyObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 * (long)2, Operators.MultiplyObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 * (long)1, Operators.MultiplyObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 * (long)2, Operators.MultiplyObject((double)2.3, (long)2));
        }
        
        [TestMethod]
        public void MultiplyDoubleFloat()
        {
            Assert.AreEqual((double)1.2 * (float)1.2, Operators.MultiplyObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 * (float)2.3, Operators.MultiplyObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 * (float)1.2, Operators.MultiplyObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 * (float)2.3, Operators.MultiplyObject((double)2.3, (float)2.3));
        }
        
        [TestMethod]
        public void MultiplyDoubleDouble()
        {
            Assert.AreEqual((double)1.2 * (double)1.2, Operators.MultiplyObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 * (double)2.3, Operators.MultiplyObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 * (double)1.2, Operators.MultiplyObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 * (double)2.3, Operators.MultiplyObject((double)2.3, (double)2.3));
        }
        
        [TestMethod]
        public void DivideShortShort()
        {
            Assert.AreEqual((short)1 / (short)1, Operators.DivideObject((short)1, (short)1));
            Assert.AreEqual((short)1 / (short)2, Operators.DivideObject((short)1, (short)2));
            Assert.AreEqual((short)2 / (short)1, Operators.DivideObject((short)2, (short)1));
            Assert.AreEqual((short)2 / (short)2, Operators.DivideObject((short)2, (short)2));
        }
        
        [TestMethod]
        public void DivideShortInteger()
        {
            Assert.AreEqual((short)1 / (int)1, Operators.DivideObject((short)1, (int)1));
            Assert.AreEqual((short)1 / (int)2, Operators.DivideObject((short)1, (int)2));
            Assert.AreEqual((short)2 / (int)1, Operators.DivideObject((short)2, (int)1));
            Assert.AreEqual((short)2 / (int)2, Operators.DivideObject((short)2, (int)2));
        }
        
        [TestMethod]
        public void DivideShortLong()
        {
            Assert.AreEqual((short)1 / (long)1, Operators.DivideObject((short)1, (long)1));
            Assert.AreEqual((short)1 / (long)2, Operators.DivideObject((short)1, (long)2));
            Assert.AreEqual((short)2 / (long)1, Operators.DivideObject((short)2, (long)1));
            Assert.AreEqual((short)2 / (long)2, Operators.DivideObject((short)2, (long)2));
        }
        
        [TestMethod]
        public void DivideShortFloat()
        {
            Assert.AreEqual((short)1 / (float)1.2, Operators.DivideObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 / (float)2.3, Operators.DivideObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 / (float)1.2, Operators.DivideObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 / (float)2.3, Operators.DivideObject((short)2, (float)2.3));
        }
        
        [TestMethod]
        public void DivideShortDouble()
        {
            Assert.AreEqual((short)1 / (double)1.2, Operators.DivideObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 / (double)2.3, Operators.DivideObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 / (double)1.2, Operators.DivideObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 / (double)2.3, Operators.DivideObject((short)2, (double)2.3));
        }
        
        [TestMethod]
        public void DivideIntegerShort()
        {
            Assert.AreEqual((int)1 / (short)1, Operators.DivideObject((int)1, (short)1));
            Assert.AreEqual((int)1 / (short)2, Operators.DivideObject((int)1, (short)2));
            Assert.AreEqual((int)2 / (short)1, Operators.DivideObject((int)2, (short)1));
            Assert.AreEqual((int)2 / (short)2, Operators.DivideObject((int)2, (short)2));
        }
        
        [TestMethod]
        public void DivideIntegerInteger()
        {
            Assert.AreEqual((int)1 / (int)1, Operators.DivideObject((int)1, (int)1));
            Assert.AreEqual((int)1 / (int)2, Operators.DivideObject((int)1, (int)2));
            Assert.AreEqual((int)2 / (int)1, Operators.DivideObject((int)2, (int)1));
            Assert.AreEqual((int)2 / (int)2, Operators.DivideObject((int)2, (int)2));
        }
        
        [TestMethod]
        public void DivideIntegerLong()
        {
            Assert.AreEqual((int)1 / (long)1, Operators.DivideObject((int)1, (long)1));
            Assert.AreEqual((int)1 / (long)2, Operators.DivideObject((int)1, (long)2));
            Assert.AreEqual((int)2 / (long)1, Operators.DivideObject((int)2, (long)1));
            Assert.AreEqual((int)2 / (long)2, Operators.DivideObject((int)2, (long)2));
        }
        
        [TestMethod]
        public void DivideIntegerFloat()
        {
            Assert.AreEqual((int)1 / (float)1.2, Operators.DivideObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 / (float)2.3, Operators.DivideObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 / (float)1.2, Operators.DivideObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 / (float)2.3, Operators.DivideObject((int)2, (float)2.3));
        }
        
        [TestMethod]
        public void DivideIntegerDouble()
        {
            Assert.AreEqual((int)1 / (double)1.2, Operators.DivideObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 / (double)2.3, Operators.DivideObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 / (double)1.2, Operators.DivideObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 / (double)2.3, Operators.DivideObject((int)2, (double)2.3));
        }
        
        [TestMethod]
        public void DivideLongShort()
        {
            Assert.AreEqual((long)1 / (short)1, Operators.DivideObject((long)1, (short)1));
            Assert.AreEqual((long)1 / (short)2, Operators.DivideObject((long)1, (short)2));
            Assert.AreEqual((long)2 / (short)1, Operators.DivideObject((long)2, (short)1));
            Assert.AreEqual((long)2 / (short)2, Operators.DivideObject((long)2, (short)2));
        }
        
        [TestMethod]
        public void DivideLongInteger()
        {
            Assert.AreEqual((long)1 / (int)1, Operators.DivideObject((long)1, (int)1));
            Assert.AreEqual((long)1 / (int)2, Operators.DivideObject((long)1, (int)2));
            Assert.AreEqual((long)2 / (int)1, Operators.DivideObject((long)2, (int)1));
            Assert.AreEqual((long)2 / (int)2, Operators.DivideObject((long)2, (int)2));
        }
        
        [TestMethod]
        public void DivideLongLong()
        {
            Assert.AreEqual((long)1 / (long)1, Operators.DivideObject((long)1, (long)1));
            Assert.AreEqual((long)1 / (long)2, Operators.DivideObject((long)1, (long)2));
            Assert.AreEqual((long)2 / (long)1, Operators.DivideObject((long)2, (long)1));
            Assert.AreEqual((long)2 / (long)2, Operators.DivideObject((long)2, (long)2));
        }
        
        [TestMethod]
        public void DivideLongFloat()
        {
            Assert.AreEqual((long)1 / (float)1.2, Operators.DivideObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 / (float)2.3, Operators.DivideObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 / (float)1.2, Operators.DivideObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 / (float)2.3, Operators.DivideObject((long)2, (float)2.3));
        }
        
        [TestMethod]
        public void DivideLongDouble()
        {
            Assert.AreEqual((long)1 / (double)1.2, Operators.DivideObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 / (double)2.3, Operators.DivideObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 / (double)1.2, Operators.DivideObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 / (double)2.3, Operators.DivideObject((long)2, (double)2.3));
        }
        
        [TestMethod]
        public void DivideFloatShort()
        {
            Assert.AreEqual((float)1.2 / (short)1, Operators.DivideObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 / (short)2, Operators.DivideObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 / (short)1, Operators.DivideObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 / (short)2, Operators.DivideObject((float)2.3, (short)2));
        }
        
        [TestMethod]
        public void DivideFloatInteger()
        {
            Assert.AreEqual((float)1.2 / (int)1, Operators.DivideObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 / (int)2, Operators.DivideObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 / (int)1, Operators.DivideObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 / (int)2, Operators.DivideObject((float)2.3, (int)2));
        }
        
        [TestMethod]
        public void DivideFloatLong()
        {
            Assert.AreEqual((float)1.2 / (long)1, Operators.DivideObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 / (long)2, Operators.DivideObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 / (long)1, Operators.DivideObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 / (long)2, Operators.DivideObject((float)2.3, (long)2));
        }
        
        [TestMethod]
        public void DivideFloatFloat()
        {
            Assert.AreEqual((float)1.2 / (float)1.2, Operators.DivideObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 / (float)2.3, Operators.DivideObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 / (float)1.2, Operators.DivideObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 / (float)2.3, Operators.DivideObject((float)2.3, (float)2.3));
        }
        
        [TestMethod]
        public void DivideFloatDouble()
        {
            Assert.AreEqual((float)1.2 / (double)1.2, Operators.DivideObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 / (double)2.3, Operators.DivideObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 / (double)1.2, Operators.DivideObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 / (double)2.3, Operators.DivideObject((float)2.3, (double)2.3));
        }
        
        [TestMethod]
        public void DivideDoubleShort()
        {
            Assert.AreEqual((double)1.2 / (short)1, Operators.DivideObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 / (short)2, Operators.DivideObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 / (short)1, Operators.DivideObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 / (short)2, Operators.DivideObject((double)2.3, (short)2));
        }
        
        [TestMethod]
        public void DivideDoubleInteger()
        {
            Assert.AreEqual((double)1.2 / (int)1, Operators.DivideObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 / (int)2, Operators.DivideObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 / (int)1, Operators.DivideObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 / (int)2, Operators.DivideObject((double)2.3, (int)2));
        }
        
        [TestMethod]
        public void DivideDoubleLong()
        {
            Assert.AreEqual((double)1.2 / (long)1, Operators.DivideObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 / (long)2, Operators.DivideObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 / (long)1, Operators.DivideObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 / (long)2, Operators.DivideObject((double)2.3, (long)2));
        }
        
        [TestMethod]
        public void DivideDoubleFloat()
        {
            Assert.AreEqual((double)1.2 / (float)1.2, Operators.DivideObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 / (float)2.3, Operators.DivideObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 / (float)1.2, Operators.DivideObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 / (float)2.3, Operators.DivideObject((double)2.3, (float)2.3));
        }
        
        [TestMethod]
        public void DivideDoubleDouble()
        {
            Assert.AreEqual((double)1.2 / (double)1.2, Operators.DivideObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 / (double)2.3, Operators.DivideObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 / (double)1.2, Operators.DivideObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 / (double)2.3, Operators.DivideObject((double)2.3, (double)2.3));
        }
        
    }
}
