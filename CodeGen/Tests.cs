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
        private Operators operators;
        
        [TestInitialize]
        public void Setup()
        {
            this.operators = new Operators();
        }        

        [TestMethod]
        public void AddShortShort()
        {
            Assert.AreEqual((short)1 + (short)1, this.operators.AddObject((short)1, (short)1));
            Assert.AreEqual((short)1 + (short)2, this.operators.AddObject((short)1, (short)2));
            Assert.AreEqual((short)2 + (short)1, this.operators.AddObject((short)2, (short)1));
            Assert.AreEqual((short)2 + (short)2, this.operators.AddObject((short)2, (short)2));
        }        

        [TestMethod]
        public void AddShortInteger()
        {
            Assert.AreEqual((short)1 + (int)1, this.operators.AddObject((short)1, (int)1));
            Assert.AreEqual((short)1 + (int)2, this.operators.AddObject((short)1, (int)2));
            Assert.AreEqual((short)2 + (int)1, this.operators.AddObject((short)2, (int)1));
            Assert.AreEqual((short)2 + (int)2, this.operators.AddObject((short)2, (int)2));
        }        

        [TestMethod]
        public void AddShortLong()
        {
            Assert.AreEqual((short)1 + (long)1, this.operators.AddObject((short)1, (long)1));
            Assert.AreEqual((short)1 + (long)2, this.operators.AddObject((short)1, (long)2));
            Assert.AreEqual((short)2 + (long)1, this.operators.AddObject((short)2, (long)1));
            Assert.AreEqual((short)2 + (long)2, this.operators.AddObject((short)2, (long)2));
        }        

        [TestMethod]
        public void AddShortFloat()
        {
            Assert.AreEqual((short)1 + (float)1.2, this.operators.AddObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 + (float)2.3, this.operators.AddObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 + (float)1.2, this.operators.AddObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 + (float)2.3, this.operators.AddObject((short)2, (float)2.3));
        }        

        [TestMethod]
        public void AddShortDouble()
        {
            Assert.AreEqual((short)1 + (double)1.2, this.operators.AddObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 + (double)2.3, this.operators.AddObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 + (double)1.2, this.operators.AddObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 + (double)2.3, this.operators.AddObject((short)2, (double)2.3));
        }        

        [TestMethod]
        public void AddIntegerShort()
        {
            Assert.AreEqual((int)1 + (short)1, this.operators.AddObject((int)1, (short)1));
            Assert.AreEqual((int)1 + (short)2, this.operators.AddObject((int)1, (short)2));
            Assert.AreEqual((int)2 + (short)1, this.operators.AddObject((int)2, (short)1));
            Assert.AreEqual((int)2 + (short)2, this.operators.AddObject((int)2, (short)2));
        }        

        [TestMethod]
        public void AddIntegerInteger()
        {
            Assert.AreEqual((int)1 + (int)1, this.operators.AddObject((int)1, (int)1));
            Assert.AreEqual((int)1 + (int)2, this.operators.AddObject((int)1, (int)2));
            Assert.AreEqual((int)2 + (int)1, this.operators.AddObject((int)2, (int)1));
            Assert.AreEqual((int)2 + (int)2, this.operators.AddObject((int)2, (int)2));
        }        

        [TestMethod]
        public void AddIntegerLong()
        {
            Assert.AreEqual((int)1 + (long)1, this.operators.AddObject((int)1, (long)1));
            Assert.AreEqual((int)1 + (long)2, this.operators.AddObject((int)1, (long)2));
            Assert.AreEqual((int)2 + (long)1, this.operators.AddObject((int)2, (long)1));
            Assert.AreEqual((int)2 + (long)2, this.operators.AddObject((int)2, (long)2));
        }        

        [TestMethod]
        public void AddIntegerFloat()
        {
            Assert.AreEqual((int)1 + (float)1.2, this.operators.AddObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 + (float)2.3, this.operators.AddObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 + (float)1.2, this.operators.AddObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 + (float)2.3, this.operators.AddObject((int)2, (float)2.3));
        }        

        [TestMethod]
        public void AddIntegerDouble()
        {
            Assert.AreEqual((int)1 + (double)1.2, this.operators.AddObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 + (double)2.3, this.operators.AddObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 + (double)1.2, this.operators.AddObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 + (double)2.3, this.operators.AddObject((int)2, (double)2.3));
        }        

        [TestMethod]
        public void AddLongShort()
        {
            Assert.AreEqual((long)1 + (short)1, this.operators.AddObject((long)1, (short)1));
            Assert.AreEqual((long)1 + (short)2, this.operators.AddObject((long)1, (short)2));
            Assert.AreEqual((long)2 + (short)1, this.operators.AddObject((long)2, (short)1));
            Assert.AreEqual((long)2 + (short)2, this.operators.AddObject((long)2, (short)2));
        }        

        [TestMethod]
        public void AddLongInteger()
        {
            Assert.AreEqual((long)1 + (int)1, this.operators.AddObject((long)1, (int)1));
            Assert.AreEqual((long)1 + (int)2, this.operators.AddObject((long)1, (int)2));
            Assert.AreEqual((long)2 + (int)1, this.operators.AddObject((long)2, (int)1));
            Assert.AreEqual((long)2 + (int)2, this.operators.AddObject((long)2, (int)2));
        }        

        [TestMethod]
        public void AddLongLong()
        {
            Assert.AreEqual((long)1 + (long)1, this.operators.AddObject((long)1, (long)1));
            Assert.AreEqual((long)1 + (long)2, this.operators.AddObject((long)1, (long)2));
            Assert.AreEqual((long)2 + (long)1, this.operators.AddObject((long)2, (long)1));
            Assert.AreEqual((long)2 + (long)2, this.operators.AddObject((long)2, (long)2));
        }        

        [TestMethod]
        public void AddLongFloat()
        {
            Assert.AreEqual((long)1 + (float)1.2, this.operators.AddObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 + (float)2.3, this.operators.AddObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 + (float)1.2, this.operators.AddObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 + (float)2.3, this.operators.AddObject((long)2, (float)2.3));
        }        

        [TestMethod]
        public void AddLongDouble()
        {
            Assert.AreEqual((long)1 + (double)1.2, this.operators.AddObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 + (double)2.3, this.operators.AddObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 + (double)1.2, this.operators.AddObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 + (double)2.3, this.operators.AddObject((long)2, (double)2.3));
        }        

        [TestMethod]
        public void AddFloatShort()
        {
            Assert.AreEqual((float)1.2 + (short)1, this.operators.AddObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 + (short)2, this.operators.AddObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 + (short)1, this.operators.AddObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 + (short)2, this.operators.AddObject((float)2.3, (short)2));
        }        

        [TestMethod]
        public void AddFloatInteger()
        {
            Assert.AreEqual((float)1.2 + (int)1, this.operators.AddObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 + (int)2, this.operators.AddObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 + (int)1, this.operators.AddObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 + (int)2, this.operators.AddObject((float)2.3, (int)2));
        }        

        [TestMethod]
        public void AddFloatLong()
        {
            Assert.AreEqual((float)1.2 + (long)1, this.operators.AddObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 + (long)2, this.operators.AddObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 + (long)1, this.operators.AddObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 + (long)2, this.operators.AddObject((float)2.3, (long)2));
        }        

        [TestMethod]
        public void AddFloatFloat()
        {
            Assert.AreEqual((float)1.2 + (float)1.2, this.operators.AddObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 + (float)2.3, this.operators.AddObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 + (float)1.2, this.operators.AddObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 + (float)2.3, this.operators.AddObject((float)2.3, (float)2.3));
        }        

        [TestMethod]
        public void AddFloatDouble()
        {
            Assert.AreEqual((float)1.2 + (double)1.2, this.operators.AddObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 + (double)2.3, this.operators.AddObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 + (double)1.2, this.operators.AddObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 + (double)2.3, this.operators.AddObject((float)2.3, (double)2.3));
        }        

        [TestMethod]
        public void AddDoubleShort()
        {
            Assert.AreEqual((double)1.2 + (short)1, this.operators.AddObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 + (short)2, this.operators.AddObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 + (short)1, this.operators.AddObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 + (short)2, this.operators.AddObject((double)2.3, (short)2));
        }        

        [TestMethod]
        public void AddDoubleInteger()
        {
            Assert.AreEqual((double)1.2 + (int)1, this.operators.AddObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 + (int)2, this.operators.AddObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 + (int)1, this.operators.AddObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 + (int)2, this.operators.AddObject((double)2.3, (int)2));
        }        

        [TestMethod]
        public void AddDoubleLong()
        {
            Assert.AreEqual((double)1.2 + (long)1, this.operators.AddObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 + (long)2, this.operators.AddObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 + (long)1, this.operators.AddObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 + (long)2, this.operators.AddObject((double)2.3, (long)2));
        }        

        [TestMethod]
        public void AddDoubleFloat()
        {
            Assert.AreEqual((double)1.2 + (float)1.2, this.operators.AddObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 + (float)2.3, this.operators.AddObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 + (float)1.2, this.operators.AddObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 + (float)2.3, this.operators.AddObject((double)2.3, (float)2.3));
        }        

        [TestMethod]
        public void AddDoubleDouble()
        {
            Assert.AreEqual((double)1.2 + (double)1.2, this.operators.AddObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 + (double)2.3, this.operators.AddObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 + (double)1.2, this.operators.AddObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 + (double)2.3, this.operators.AddObject((double)2.3, (double)2.3));
        }        

        [TestMethod]
        public void SubtractShortShort()
        {
            Assert.AreEqual((short)1 - (short)1, this.operators.SubtractObject((short)1, (short)1));
            Assert.AreEqual((short)1 - (short)2, this.operators.SubtractObject((short)1, (short)2));
            Assert.AreEqual((short)2 - (short)1, this.operators.SubtractObject((short)2, (short)1));
            Assert.AreEqual((short)2 - (short)2, this.operators.SubtractObject((short)2, (short)2));
        }        

        [TestMethod]
        public void SubtractShortInteger()
        {
            Assert.AreEqual((short)1 - (int)1, this.operators.SubtractObject((short)1, (int)1));
            Assert.AreEqual((short)1 - (int)2, this.operators.SubtractObject((short)1, (int)2));
            Assert.AreEqual((short)2 - (int)1, this.operators.SubtractObject((short)2, (int)1));
            Assert.AreEqual((short)2 - (int)2, this.operators.SubtractObject((short)2, (int)2));
        }        

        [TestMethod]
        public void SubtractShortLong()
        {
            Assert.AreEqual((short)1 - (long)1, this.operators.SubtractObject((short)1, (long)1));
            Assert.AreEqual((short)1 - (long)2, this.operators.SubtractObject((short)1, (long)2));
            Assert.AreEqual((short)2 - (long)1, this.operators.SubtractObject((short)2, (long)1));
            Assert.AreEqual((short)2 - (long)2, this.operators.SubtractObject((short)2, (long)2));
        }        

        [TestMethod]
        public void SubtractShortFloat()
        {
            Assert.AreEqual((short)1 - (float)1.2, this.operators.SubtractObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 - (float)2.3, this.operators.SubtractObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 - (float)1.2, this.operators.SubtractObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 - (float)2.3, this.operators.SubtractObject((short)2, (float)2.3));
        }        

        [TestMethod]
        public void SubtractShortDouble()
        {
            Assert.AreEqual((short)1 - (double)1.2, this.operators.SubtractObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 - (double)2.3, this.operators.SubtractObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 - (double)1.2, this.operators.SubtractObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 - (double)2.3, this.operators.SubtractObject((short)2, (double)2.3));
        }        

        [TestMethod]
        public void SubtractIntegerShort()
        {
            Assert.AreEqual((int)1 - (short)1, this.operators.SubtractObject((int)1, (short)1));
            Assert.AreEqual((int)1 - (short)2, this.operators.SubtractObject((int)1, (short)2));
            Assert.AreEqual((int)2 - (short)1, this.operators.SubtractObject((int)2, (short)1));
            Assert.AreEqual((int)2 - (short)2, this.operators.SubtractObject((int)2, (short)2));
        }        

        [TestMethod]
        public void SubtractIntegerInteger()
        {
            Assert.AreEqual((int)1 - (int)1, this.operators.SubtractObject((int)1, (int)1));
            Assert.AreEqual((int)1 - (int)2, this.operators.SubtractObject((int)1, (int)2));
            Assert.AreEqual((int)2 - (int)1, this.operators.SubtractObject((int)2, (int)1));
            Assert.AreEqual((int)2 - (int)2, this.operators.SubtractObject((int)2, (int)2));
        }        

        [TestMethod]
        public void SubtractIntegerLong()
        {
            Assert.AreEqual((int)1 - (long)1, this.operators.SubtractObject((int)1, (long)1));
            Assert.AreEqual((int)1 - (long)2, this.operators.SubtractObject((int)1, (long)2));
            Assert.AreEqual((int)2 - (long)1, this.operators.SubtractObject((int)2, (long)1));
            Assert.AreEqual((int)2 - (long)2, this.operators.SubtractObject((int)2, (long)2));
        }        

        [TestMethod]
        public void SubtractIntegerFloat()
        {
            Assert.AreEqual((int)1 - (float)1.2, this.operators.SubtractObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 - (float)2.3, this.operators.SubtractObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 - (float)1.2, this.operators.SubtractObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 - (float)2.3, this.operators.SubtractObject((int)2, (float)2.3));
        }        

        [TestMethod]
        public void SubtractIntegerDouble()
        {
            Assert.AreEqual((int)1 - (double)1.2, this.operators.SubtractObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 - (double)2.3, this.operators.SubtractObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 - (double)1.2, this.operators.SubtractObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 - (double)2.3, this.operators.SubtractObject((int)2, (double)2.3));
        }        

        [TestMethod]
        public void SubtractLongShort()
        {
            Assert.AreEqual((long)1 - (short)1, this.operators.SubtractObject((long)1, (short)1));
            Assert.AreEqual((long)1 - (short)2, this.operators.SubtractObject((long)1, (short)2));
            Assert.AreEqual((long)2 - (short)1, this.operators.SubtractObject((long)2, (short)1));
            Assert.AreEqual((long)2 - (short)2, this.operators.SubtractObject((long)2, (short)2));
        }        

        [TestMethod]
        public void SubtractLongInteger()
        {
            Assert.AreEqual((long)1 - (int)1, this.operators.SubtractObject((long)1, (int)1));
            Assert.AreEqual((long)1 - (int)2, this.operators.SubtractObject((long)1, (int)2));
            Assert.AreEqual((long)2 - (int)1, this.operators.SubtractObject((long)2, (int)1));
            Assert.AreEqual((long)2 - (int)2, this.operators.SubtractObject((long)2, (int)2));
        }        

        [TestMethod]
        public void SubtractLongLong()
        {
            Assert.AreEqual((long)1 - (long)1, this.operators.SubtractObject((long)1, (long)1));
            Assert.AreEqual((long)1 - (long)2, this.operators.SubtractObject((long)1, (long)2));
            Assert.AreEqual((long)2 - (long)1, this.operators.SubtractObject((long)2, (long)1));
            Assert.AreEqual((long)2 - (long)2, this.operators.SubtractObject((long)2, (long)2));
        }        

        [TestMethod]
        public void SubtractLongFloat()
        {
            Assert.AreEqual((long)1 - (float)1.2, this.operators.SubtractObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 - (float)2.3, this.operators.SubtractObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 - (float)1.2, this.operators.SubtractObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 - (float)2.3, this.operators.SubtractObject((long)2, (float)2.3));
        }        

        [TestMethod]
        public void SubtractLongDouble()
        {
            Assert.AreEqual((long)1 - (double)1.2, this.operators.SubtractObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 - (double)2.3, this.operators.SubtractObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 - (double)1.2, this.operators.SubtractObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 - (double)2.3, this.operators.SubtractObject((long)2, (double)2.3));
        }        

        [TestMethod]
        public void SubtractFloatShort()
        {
            Assert.AreEqual((float)1.2 - (short)1, this.operators.SubtractObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 - (short)2, this.operators.SubtractObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 - (short)1, this.operators.SubtractObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 - (short)2, this.operators.SubtractObject((float)2.3, (short)2));
        }        

        [TestMethod]
        public void SubtractFloatInteger()
        {
            Assert.AreEqual((float)1.2 - (int)1, this.operators.SubtractObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 - (int)2, this.operators.SubtractObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 - (int)1, this.operators.SubtractObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 - (int)2, this.operators.SubtractObject((float)2.3, (int)2));
        }        

        [TestMethod]
        public void SubtractFloatLong()
        {
            Assert.AreEqual((float)1.2 - (long)1, this.operators.SubtractObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 - (long)2, this.operators.SubtractObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 - (long)1, this.operators.SubtractObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 - (long)2, this.operators.SubtractObject((float)2.3, (long)2));
        }        

        [TestMethod]
        public void SubtractFloatFloat()
        {
            Assert.AreEqual((float)1.2 - (float)1.2, this.operators.SubtractObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 - (float)2.3, this.operators.SubtractObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 - (float)1.2, this.operators.SubtractObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 - (float)2.3, this.operators.SubtractObject((float)2.3, (float)2.3));
        }        

        [TestMethod]
        public void SubtractFloatDouble()
        {
            Assert.AreEqual((float)1.2 - (double)1.2, this.operators.SubtractObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 - (double)2.3, this.operators.SubtractObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 - (double)1.2, this.operators.SubtractObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 - (double)2.3, this.operators.SubtractObject((float)2.3, (double)2.3));
        }        

        [TestMethod]
        public void SubtractDoubleShort()
        {
            Assert.AreEqual((double)1.2 - (short)1, this.operators.SubtractObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 - (short)2, this.operators.SubtractObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 - (short)1, this.operators.SubtractObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 - (short)2, this.operators.SubtractObject((double)2.3, (short)2));
        }        

        [TestMethod]
        public void SubtractDoubleInteger()
        {
            Assert.AreEqual((double)1.2 - (int)1, this.operators.SubtractObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 - (int)2, this.operators.SubtractObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 - (int)1, this.operators.SubtractObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 - (int)2, this.operators.SubtractObject((double)2.3, (int)2));
        }        

        [TestMethod]
        public void SubtractDoubleLong()
        {
            Assert.AreEqual((double)1.2 - (long)1, this.operators.SubtractObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 - (long)2, this.operators.SubtractObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 - (long)1, this.operators.SubtractObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 - (long)2, this.operators.SubtractObject((double)2.3, (long)2));
        }        

        [TestMethod]
        public void SubtractDoubleFloat()
        {
            Assert.AreEqual((double)1.2 - (float)1.2, this.operators.SubtractObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 - (float)2.3, this.operators.SubtractObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 - (float)1.2, this.operators.SubtractObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 - (float)2.3, this.operators.SubtractObject((double)2.3, (float)2.3));
        }        

        [TestMethod]
        public void SubtractDoubleDouble()
        {
            Assert.AreEqual((double)1.2 - (double)1.2, this.operators.SubtractObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 - (double)2.3, this.operators.SubtractObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 - (double)1.2, this.operators.SubtractObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 - (double)2.3, this.operators.SubtractObject((double)2.3, (double)2.3));
        }        

        [TestMethod]
        public void MultiplyShortShort()
        {
            Assert.AreEqual((short)1 * (short)1, this.operators.MultiplyObject((short)1, (short)1));
            Assert.AreEqual((short)1 * (short)2, this.operators.MultiplyObject((short)1, (short)2));
            Assert.AreEqual((short)2 * (short)1, this.operators.MultiplyObject((short)2, (short)1));
            Assert.AreEqual((short)2 * (short)2, this.operators.MultiplyObject((short)2, (short)2));
        }        

        [TestMethod]
        public void MultiplyShortInteger()
        {
            Assert.AreEqual((short)1 * (int)1, this.operators.MultiplyObject((short)1, (int)1));
            Assert.AreEqual((short)1 * (int)2, this.operators.MultiplyObject((short)1, (int)2));
            Assert.AreEqual((short)2 * (int)1, this.operators.MultiplyObject((short)2, (int)1));
            Assert.AreEqual((short)2 * (int)2, this.operators.MultiplyObject((short)2, (int)2));
        }        

        [TestMethod]
        public void MultiplyShortLong()
        {
            Assert.AreEqual((short)1 * (long)1, this.operators.MultiplyObject((short)1, (long)1));
            Assert.AreEqual((short)1 * (long)2, this.operators.MultiplyObject((short)1, (long)2));
            Assert.AreEqual((short)2 * (long)1, this.operators.MultiplyObject((short)2, (long)1));
            Assert.AreEqual((short)2 * (long)2, this.operators.MultiplyObject((short)2, (long)2));
        }        

        [TestMethod]
        public void MultiplyShortFloat()
        {
            Assert.AreEqual((short)1 * (float)1.2, this.operators.MultiplyObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 * (float)2.3, this.operators.MultiplyObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 * (float)1.2, this.operators.MultiplyObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 * (float)2.3, this.operators.MultiplyObject((short)2, (float)2.3));
        }        

        [TestMethod]
        public void MultiplyShortDouble()
        {
            Assert.AreEqual((short)1 * (double)1.2, this.operators.MultiplyObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 * (double)2.3, this.operators.MultiplyObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 * (double)1.2, this.operators.MultiplyObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 * (double)2.3, this.operators.MultiplyObject((short)2, (double)2.3));
        }        

        [TestMethod]
        public void MultiplyIntegerShort()
        {
            Assert.AreEqual((int)1 * (short)1, this.operators.MultiplyObject((int)1, (short)1));
            Assert.AreEqual((int)1 * (short)2, this.operators.MultiplyObject((int)1, (short)2));
            Assert.AreEqual((int)2 * (short)1, this.operators.MultiplyObject((int)2, (short)1));
            Assert.AreEqual((int)2 * (short)2, this.operators.MultiplyObject((int)2, (short)2));
        }        

        [TestMethod]
        public void MultiplyIntegerInteger()
        {
            Assert.AreEqual((int)1 * (int)1, this.operators.MultiplyObject((int)1, (int)1));
            Assert.AreEqual((int)1 * (int)2, this.operators.MultiplyObject((int)1, (int)2));
            Assert.AreEqual((int)2 * (int)1, this.operators.MultiplyObject((int)2, (int)1));
            Assert.AreEqual((int)2 * (int)2, this.operators.MultiplyObject((int)2, (int)2));
        }        

        [TestMethod]
        public void MultiplyIntegerLong()
        {
            Assert.AreEqual((int)1 * (long)1, this.operators.MultiplyObject((int)1, (long)1));
            Assert.AreEqual((int)1 * (long)2, this.operators.MultiplyObject((int)1, (long)2));
            Assert.AreEqual((int)2 * (long)1, this.operators.MultiplyObject((int)2, (long)1));
            Assert.AreEqual((int)2 * (long)2, this.operators.MultiplyObject((int)2, (long)2));
        }        

        [TestMethod]
        public void MultiplyIntegerFloat()
        {
            Assert.AreEqual((int)1 * (float)1.2, this.operators.MultiplyObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 * (float)2.3, this.operators.MultiplyObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 * (float)1.2, this.operators.MultiplyObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 * (float)2.3, this.operators.MultiplyObject((int)2, (float)2.3));
        }        

        [TestMethod]
        public void MultiplyIntegerDouble()
        {
            Assert.AreEqual((int)1 * (double)1.2, this.operators.MultiplyObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 * (double)2.3, this.operators.MultiplyObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 * (double)1.2, this.operators.MultiplyObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 * (double)2.3, this.operators.MultiplyObject((int)2, (double)2.3));
        }        

        [TestMethod]
        public void MultiplyLongShort()
        {
            Assert.AreEqual((long)1 * (short)1, this.operators.MultiplyObject((long)1, (short)1));
            Assert.AreEqual((long)1 * (short)2, this.operators.MultiplyObject((long)1, (short)2));
            Assert.AreEqual((long)2 * (short)1, this.operators.MultiplyObject((long)2, (short)1));
            Assert.AreEqual((long)2 * (short)2, this.operators.MultiplyObject((long)2, (short)2));
        }        

        [TestMethod]
        public void MultiplyLongInteger()
        {
            Assert.AreEqual((long)1 * (int)1, this.operators.MultiplyObject((long)1, (int)1));
            Assert.AreEqual((long)1 * (int)2, this.operators.MultiplyObject((long)1, (int)2));
            Assert.AreEqual((long)2 * (int)1, this.operators.MultiplyObject((long)2, (int)1));
            Assert.AreEqual((long)2 * (int)2, this.operators.MultiplyObject((long)2, (int)2));
        }        

        [TestMethod]
        public void MultiplyLongLong()
        {
            Assert.AreEqual((long)1 * (long)1, this.operators.MultiplyObject((long)1, (long)1));
            Assert.AreEqual((long)1 * (long)2, this.operators.MultiplyObject((long)1, (long)2));
            Assert.AreEqual((long)2 * (long)1, this.operators.MultiplyObject((long)2, (long)1));
            Assert.AreEqual((long)2 * (long)2, this.operators.MultiplyObject((long)2, (long)2));
        }        

        [TestMethod]
        public void MultiplyLongFloat()
        {
            Assert.AreEqual((long)1 * (float)1.2, this.operators.MultiplyObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 * (float)2.3, this.operators.MultiplyObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 * (float)1.2, this.operators.MultiplyObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 * (float)2.3, this.operators.MultiplyObject((long)2, (float)2.3));
        }        

        [TestMethod]
        public void MultiplyLongDouble()
        {
            Assert.AreEqual((long)1 * (double)1.2, this.operators.MultiplyObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 * (double)2.3, this.operators.MultiplyObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 * (double)1.2, this.operators.MultiplyObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 * (double)2.3, this.operators.MultiplyObject((long)2, (double)2.3));
        }        

        [TestMethod]
        public void MultiplyFloatShort()
        {
            Assert.AreEqual((float)1.2 * (short)1, this.operators.MultiplyObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 * (short)2, this.operators.MultiplyObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 * (short)1, this.operators.MultiplyObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 * (short)2, this.operators.MultiplyObject((float)2.3, (short)2));
        }        

        [TestMethod]
        public void MultiplyFloatInteger()
        {
            Assert.AreEqual((float)1.2 * (int)1, this.operators.MultiplyObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 * (int)2, this.operators.MultiplyObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 * (int)1, this.operators.MultiplyObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 * (int)2, this.operators.MultiplyObject((float)2.3, (int)2));
        }        

        [TestMethod]
        public void MultiplyFloatLong()
        {
            Assert.AreEqual((float)1.2 * (long)1, this.operators.MultiplyObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 * (long)2, this.operators.MultiplyObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 * (long)1, this.operators.MultiplyObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 * (long)2, this.operators.MultiplyObject((float)2.3, (long)2));
        }        

        [TestMethod]
        public void MultiplyFloatFloat()
        {
            Assert.AreEqual((float)1.2 * (float)1.2, this.operators.MultiplyObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 * (float)2.3, this.operators.MultiplyObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 * (float)1.2, this.operators.MultiplyObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 * (float)2.3, this.operators.MultiplyObject((float)2.3, (float)2.3));
        }        

        [TestMethod]
        public void MultiplyFloatDouble()
        {
            Assert.AreEqual((float)1.2 * (double)1.2, this.operators.MultiplyObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 * (double)2.3, this.operators.MultiplyObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 * (double)1.2, this.operators.MultiplyObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 * (double)2.3, this.operators.MultiplyObject((float)2.3, (double)2.3));
        }        

        [TestMethod]
        public void MultiplyDoubleShort()
        {
            Assert.AreEqual((double)1.2 * (short)1, this.operators.MultiplyObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 * (short)2, this.operators.MultiplyObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 * (short)1, this.operators.MultiplyObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 * (short)2, this.operators.MultiplyObject((double)2.3, (short)2));
        }        

        [TestMethod]
        public void MultiplyDoubleInteger()
        {
            Assert.AreEqual((double)1.2 * (int)1, this.operators.MultiplyObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 * (int)2, this.operators.MultiplyObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 * (int)1, this.operators.MultiplyObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 * (int)2, this.operators.MultiplyObject((double)2.3, (int)2));
        }        

        [TestMethod]
        public void MultiplyDoubleLong()
        {
            Assert.AreEqual((double)1.2 * (long)1, this.operators.MultiplyObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 * (long)2, this.operators.MultiplyObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 * (long)1, this.operators.MultiplyObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 * (long)2, this.operators.MultiplyObject((double)2.3, (long)2));
        }        

        [TestMethod]
        public void MultiplyDoubleFloat()
        {
            Assert.AreEqual((double)1.2 * (float)1.2, this.operators.MultiplyObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 * (float)2.3, this.operators.MultiplyObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 * (float)1.2, this.operators.MultiplyObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 * (float)2.3, this.operators.MultiplyObject((double)2.3, (float)2.3));
        }        

        [TestMethod]
        public void MultiplyDoubleDouble()
        {
            Assert.AreEqual((double)1.2 * (double)1.2, this.operators.MultiplyObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 * (double)2.3, this.operators.MultiplyObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 * (double)1.2, this.operators.MultiplyObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 * (double)2.3, this.operators.MultiplyObject((double)2.3, (double)2.3));
        }        

        [TestMethod]
        public void DivideShortShort()
        {
            Assert.AreEqual((short)1 / (short)1, this.operators.DivideObject((short)1, (short)1));
            Assert.AreEqual((short)1 / (short)2, this.operators.DivideObject((short)1, (short)2));
            Assert.AreEqual((short)2 / (short)1, this.operators.DivideObject((short)2, (short)1));
            Assert.AreEqual((short)2 / (short)2, this.operators.DivideObject((short)2, (short)2));
        }        

        [TestMethod]
        public void DivideShortInteger()
        {
            Assert.AreEqual((short)1 / (int)1, this.operators.DivideObject((short)1, (int)1));
            Assert.AreEqual((short)1 / (int)2, this.operators.DivideObject((short)1, (int)2));
            Assert.AreEqual((short)2 / (int)1, this.operators.DivideObject((short)2, (int)1));
            Assert.AreEqual((short)2 / (int)2, this.operators.DivideObject((short)2, (int)2));
        }        

        [TestMethod]
        public void DivideShortLong()
        {
            Assert.AreEqual((short)1 / (long)1, this.operators.DivideObject((short)1, (long)1));
            Assert.AreEqual((short)1 / (long)2, this.operators.DivideObject((short)1, (long)2));
            Assert.AreEqual((short)2 / (long)1, this.operators.DivideObject((short)2, (long)1));
            Assert.AreEqual((short)2 / (long)2, this.operators.DivideObject((short)2, (long)2));
        }        

        [TestMethod]
        public void DivideShortFloat()
        {
            Assert.AreEqual((short)1 / (float)1.2, this.operators.DivideObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 / (float)2.3, this.operators.DivideObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 / (float)1.2, this.operators.DivideObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 / (float)2.3, this.operators.DivideObject((short)2, (float)2.3));
        }        

        [TestMethod]
        public void DivideShortDouble()
        {
            Assert.AreEqual((short)1 / (double)1.2, this.operators.DivideObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 / (double)2.3, this.operators.DivideObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 / (double)1.2, this.operators.DivideObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 / (double)2.3, this.operators.DivideObject((short)2, (double)2.3));
        }        

        [TestMethod]
        public void DivideIntegerShort()
        {
            Assert.AreEqual((int)1 / (short)1, this.operators.DivideObject((int)1, (short)1));
            Assert.AreEqual((int)1 / (short)2, this.operators.DivideObject((int)1, (short)2));
            Assert.AreEqual((int)2 / (short)1, this.operators.DivideObject((int)2, (short)1));
            Assert.AreEqual((int)2 / (short)2, this.operators.DivideObject((int)2, (short)2));
        }        

        [TestMethod]
        public void DivideIntegerInteger()
        {
            Assert.AreEqual((int)1 / (int)1, this.operators.DivideObject((int)1, (int)1));
            Assert.AreEqual((int)1 / (int)2, this.operators.DivideObject((int)1, (int)2));
            Assert.AreEqual((int)2 / (int)1, this.operators.DivideObject((int)2, (int)1));
            Assert.AreEqual((int)2 / (int)2, this.operators.DivideObject((int)2, (int)2));
        }        

        [TestMethod]
        public void DivideIntegerLong()
        {
            Assert.AreEqual((int)1 / (long)1, this.operators.DivideObject((int)1, (long)1));
            Assert.AreEqual((int)1 / (long)2, this.operators.DivideObject((int)1, (long)2));
            Assert.AreEqual((int)2 / (long)1, this.operators.DivideObject((int)2, (long)1));
            Assert.AreEqual((int)2 / (long)2, this.operators.DivideObject((int)2, (long)2));
        }        

        [TestMethod]
        public void DivideIntegerFloat()
        {
            Assert.AreEqual((int)1 / (float)1.2, this.operators.DivideObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 / (float)2.3, this.operators.DivideObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 / (float)1.2, this.operators.DivideObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 / (float)2.3, this.operators.DivideObject((int)2, (float)2.3));
        }        

        [TestMethod]
        public void DivideIntegerDouble()
        {
            Assert.AreEqual((int)1 / (double)1.2, this.operators.DivideObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 / (double)2.3, this.operators.DivideObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 / (double)1.2, this.operators.DivideObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 / (double)2.3, this.operators.DivideObject((int)2, (double)2.3));
        }        

        [TestMethod]
        public void DivideLongShort()
        {
            Assert.AreEqual((long)1 / (short)1, this.operators.DivideObject((long)1, (short)1));
            Assert.AreEqual((long)1 / (short)2, this.operators.DivideObject((long)1, (short)2));
            Assert.AreEqual((long)2 / (short)1, this.operators.DivideObject((long)2, (short)1));
            Assert.AreEqual((long)2 / (short)2, this.operators.DivideObject((long)2, (short)2));
        }        

        [TestMethod]
        public void DivideLongInteger()
        {
            Assert.AreEqual((long)1 / (int)1, this.operators.DivideObject((long)1, (int)1));
            Assert.AreEqual((long)1 / (int)2, this.operators.DivideObject((long)1, (int)2));
            Assert.AreEqual((long)2 / (int)1, this.operators.DivideObject((long)2, (int)1));
            Assert.AreEqual((long)2 / (int)2, this.operators.DivideObject((long)2, (int)2));
        }        

        [TestMethod]
        public void DivideLongLong()
        {
            Assert.AreEqual((long)1 / (long)1, this.operators.DivideObject((long)1, (long)1));
            Assert.AreEqual((long)1 / (long)2, this.operators.DivideObject((long)1, (long)2));
            Assert.AreEqual((long)2 / (long)1, this.operators.DivideObject((long)2, (long)1));
            Assert.AreEqual((long)2 / (long)2, this.operators.DivideObject((long)2, (long)2));
        }        

        [TestMethod]
        public void DivideLongFloat()
        {
            Assert.AreEqual((long)1 / (float)1.2, this.operators.DivideObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 / (float)2.3, this.operators.DivideObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 / (float)1.2, this.operators.DivideObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 / (float)2.3, this.operators.DivideObject((long)2, (float)2.3));
        }        

        [TestMethod]
        public void DivideLongDouble()
        {
            Assert.AreEqual((long)1 / (double)1.2, this.operators.DivideObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 / (double)2.3, this.operators.DivideObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 / (double)1.2, this.operators.DivideObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 / (double)2.3, this.operators.DivideObject((long)2, (double)2.3));
        }        

        [TestMethod]
        public void DivideFloatShort()
        {
            Assert.AreEqual((float)1.2 / (short)1, this.operators.DivideObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 / (short)2, this.operators.DivideObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 / (short)1, this.operators.DivideObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 / (short)2, this.operators.DivideObject((float)2.3, (short)2));
        }        

        [TestMethod]
        public void DivideFloatInteger()
        {
            Assert.AreEqual((float)1.2 / (int)1, this.operators.DivideObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 / (int)2, this.operators.DivideObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 / (int)1, this.operators.DivideObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 / (int)2, this.operators.DivideObject((float)2.3, (int)2));
        }        

        [TestMethod]
        public void DivideFloatLong()
        {
            Assert.AreEqual((float)1.2 / (long)1, this.operators.DivideObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 / (long)2, this.operators.DivideObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 / (long)1, this.operators.DivideObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 / (long)2, this.operators.DivideObject((float)2.3, (long)2));
        }        

        [TestMethod]
        public void DivideFloatFloat()
        {
            Assert.AreEqual((float)1.2 / (float)1.2, this.operators.DivideObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 / (float)2.3, this.operators.DivideObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 / (float)1.2, this.operators.DivideObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 / (float)2.3, this.operators.DivideObject((float)2.3, (float)2.3));
        }        

        [TestMethod]
        public void DivideFloatDouble()
        {
            Assert.AreEqual((float)1.2 / (double)1.2, this.operators.DivideObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 / (double)2.3, this.operators.DivideObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 / (double)1.2, this.operators.DivideObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 / (double)2.3, this.operators.DivideObject((float)2.3, (double)2.3));
        }        

        [TestMethod]
        public void DivideDoubleShort()
        {
            Assert.AreEqual((double)1.2 / (short)1, this.operators.DivideObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 / (short)2, this.operators.DivideObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 / (short)1, this.operators.DivideObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 / (short)2, this.operators.DivideObject((double)2.3, (short)2));
        }        

        [TestMethod]
        public void DivideDoubleInteger()
        {
            Assert.AreEqual((double)1.2 / (int)1, this.operators.DivideObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 / (int)2, this.operators.DivideObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 / (int)1, this.operators.DivideObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 / (int)2, this.operators.DivideObject((double)2.3, (int)2));
        }        

        [TestMethod]
        public void DivideDoubleLong()
        {
            Assert.AreEqual((double)1.2 / (long)1, this.operators.DivideObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 / (long)2, this.operators.DivideObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 / (long)1, this.operators.DivideObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 / (long)2, this.operators.DivideObject((double)2.3, (long)2));
        }        

        [TestMethod]
        public void DivideDoubleFloat()
        {
            Assert.AreEqual((double)1.2 / (float)1.2, this.operators.DivideObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 / (float)2.3, this.operators.DivideObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 / (float)1.2, this.operators.DivideObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 / (float)2.3, this.operators.DivideObject((double)2.3, (float)2.3));
        }        

        [TestMethod]
        public void DivideDoubleDouble()
        {
            Assert.AreEqual((double)1.2 / (double)1.2, this.operators.DivideObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 / (double)2.3, this.operators.DivideObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 / (double)1.2, this.operators.DivideObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 / (double)2.3, this.operators.DivideObject((double)2.3, (double)2.3));
        }        

        [TestMethod]
        public void EqualShortShort()
        {
            Assert.AreEqual((short)1 == (short)1, this.operators.EqualObject((short)1, (short)1));
            Assert.AreEqual((short)1 == (short)2, this.operators.EqualObject((short)1, (short)2));
            Assert.AreEqual((short)2 == (short)1, this.operators.EqualObject((short)2, (short)1));
            Assert.AreEqual((short)2 == (short)2, this.operators.EqualObject((short)2, (short)2));
        }        

        [TestMethod]
        public void EqualShortInteger()
        {
            Assert.AreEqual((short)1 == (int)1, this.operators.EqualObject((short)1, (int)1));
            Assert.AreEqual((short)1 == (int)2, this.operators.EqualObject((short)1, (int)2));
            Assert.AreEqual((short)2 == (int)1, this.operators.EqualObject((short)2, (int)1));
            Assert.AreEqual((short)2 == (int)2, this.operators.EqualObject((short)2, (int)2));
        }        

        [TestMethod]
        public void EqualShortLong()
        {
            Assert.AreEqual((short)1 == (long)1, this.operators.EqualObject((short)1, (long)1));
            Assert.AreEqual((short)1 == (long)2, this.operators.EqualObject((short)1, (long)2));
            Assert.AreEqual((short)2 == (long)1, this.operators.EqualObject((short)2, (long)1));
            Assert.AreEqual((short)2 == (long)2, this.operators.EqualObject((short)2, (long)2));
        }        

        [TestMethod]
        public void EqualShortFloat()
        {
            Assert.AreEqual((short)1 == (float)1.2, this.operators.EqualObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 == (float)2.3, this.operators.EqualObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 == (float)1.2, this.operators.EqualObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 == (float)2.3, this.operators.EqualObject((short)2, (float)2.3));
        }        

        [TestMethod]
        public void EqualShortDouble()
        {
            Assert.AreEqual((short)1 == (double)1.2, this.operators.EqualObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 == (double)2.3, this.operators.EqualObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 == (double)1.2, this.operators.EqualObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 == (double)2.3, this.operators.EqualObject((short)2, (double)2.3));
        }        

        [TestMethod]
        public void EqualIntegerShort()
        {
            Assert.AreEqual((int)1 == (short)1, this.operators.EqualObject((int)1, (short)1));
            Assert.AreEqual((int)1 == (short)2, this.operators.EqualObject((int)1, (short)2));
            Assert.AreEqual((int)2 == (short)1, this.operators.EqualObject((int)2, (short)1));
            Assert.AreEqual((int)2 == (short)2, this.operators.EqualObject((int)2, (short)2));
        }        

        [TestMethod]
        public void EqualIntegerInteger()
        {
            Assert.AreEqual((int)1 == (int)1, this.operators.EqualObject((int)1, (int)1));
            Assert.AreEqual((int)1 == (int)2, this.operators.EqualObject((int)1, (int)2));
            Assert.AreEqual((int)2 == (int)1, this.operators.EqualObject((int)2, (int)1));
            Assert.AreEqual((int)2 == (int)2, this.operators.EqualObject((int)2, (int)2));
        }        

        [TestMethod]
        public void EqualIntegerLong()
        {
            Assert.AreEqual((int)1 == (long)1, this.operators.EqualObject((int)1, (long)1));
            Assert.AreEqual((int)1 == (long)2, this.operators.EqualObject((int)1, (long)2));
            Assert.AreEqual((int)2 == (long)1, this.operators.EqualObject((int)2, (long)1));
            Assert.AreEqual((int)2 == (long)2, this.operators.EqualObject((int)2, (long)2));
        }        

        [TestMethod]
        public void EqualIntegerFloat()
        {
            Assert.AreEqual((int)1 == (float)1.2, this.operators.EqualObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 == (float)2.3, this.operators.EqualObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 == (float)1.2, this.operators.EqualObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 == (float)2.3, this.operators.EqualObject((int)2, (float)2.3));
        }        

        [TestMethod]
        public void EqualIntegerDouble()
        {
            Assert.AreEqual((int)1 == (double)1.2, this.operators.EqualObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 == (double)2.3, this.operators.EqualObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 == (double)1.2, this.operators.EqualObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 == (double)2.3, this.operators.EqualObject((int)2, (double)2.3));
        }        

        [TestMethod]
        public void EqualLongShort()
        {
            Assert.AreEqual((long)1 == (short)1, this.operators.EqualObject((long)1, (short)1));
            Assert.AreEqual((long)1 == (short)2, this.operators.EqualObject((long)1, (short)2));
            Assert.AreEqual((long)2 == (short)1, this.operators.EqualObject((long)2, (short)1));
            Assert.AreEqual((long)2 == (short)2, this.operators.EqualObject((long)2, (short)2));
        }        

        [TestMethod]
        public void EqualLongInteger()
        {
            Assert.AreEqual((long)1 == (int)1, this.operators.EqualObject((long)1, (int)1));
            Assert.AreEqual((long)1 == (int)2, this.operators.EqualObject((long)1, (int)2));
            Assert.AreEqual((long)2 == (int)1, this.operators.EqualObject((long)2, (int)1));
            Assert.AreEqual((long)2 == (int)2, this.operators.EqualObject((long)2, (int)2));
        }        

        [TestMethod]
        public void EqualLongLong()
        {
            Assert.AreEqual((long)1 == (long)1, this.operators.EqualObject((long)1, (long)1));
            Assert.AreEqual((long)1 == (long)2, this.operators.EqualObject((long)1, (long)2));
            Assert.AreEqual((long)2 == (long)1, this.operators.EqualObject((long)2, (long)1));
            Assert.AreEqual((long)2 == (long)2, this.operators.EqualObject((long)2, (long)2));
        }        

        [TestMethod]
        public void EqualLongFloat()
        {
            Assert.AreEqual((long)1 == (float)1.2, this.operators.EqualObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 == (float)2.3, this.operators.EqualObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 == (float)1.2, this.operators.EqualObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 == (float)2.3, this.operators.EqualObject((long)2, (float)2.3));
        }        

        [TestMethod]
        public void EqualLongDouble()
        {
            Assert.AreEqual((long)1 == (double)1.2, this.operators.EqualObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 == (double)2.3, this.operators.EqualObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 == (double)1.2, this.operators.EqualObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 == (double)2.3, this.operators.EqualObject((long)2, (double)2.3));
        }        

        [TestMethod]
        public void EqualFloatShort()
        {
            Assert.AreEqual((float)1.2 == (short)1, this.operators.EqualObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 == (short)2, this.operators.EqualObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 == (short)1, this.operators.EqualObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 == (short)2, this.operators.EqualObject((float)2.3, (short)2));
        }        

        [TestMethod]
        public void EqualFloatInteger()
        {
            Assert.AreEqual((float)1.2 == (int)1, this.operators.EqualObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 == (int)2, this.operators.EqualObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 == (int)1, this.operators.EqualObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 == (int)2, this.operators.EqualObject((float)2.3, (int)2));
        }        

        [TestMethod]
        public void EqualFloatLong()
        {
            Assert.AreEqual((float)1.2 == (long)1, this.operators.EqualObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 == (long)2, this.operators.EqualObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 == (long)1, this.operators.EqualObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 == (long)2, this.operators.EqualObject((float)2.3, (long)2));
        }        

        [TestMethod]
        public void EqualFloatFloat()
        {
            Assert.AreEqual((float)1.2 == (float)1.2, this.operators.EqualObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 == (float)2.3, this.operators.EqualObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 == (float)1.2, this.operators.EqualObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 == (float)2.3, this.operators.EqualObject((float)2.3, (float)2.3));
        }        

        [TestMethod]
        public void EqualFloatDouble()
        {
            Assert.AreEqual((float)1.2 == (double)1.2, this.operators.EqualObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 == (double)2.3, this.operators.EqualObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 == (double)1.2, this.operators.EqualObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 == (double)2.3, this.operators.EqualObject((float)2.3, (double)2.3));
        }        

        [TestMethod]
        public void EqualDoubleShort()
        {
            Assert.AreEqual((double)1.2 == (short)1, this.operators.EqualObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 == (short)2, this.operators.EqualObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 == (short)1, this.operators.EqualObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 == (short)2, this.operators.EqualObject((double)2.3, (short)2));
        }        

        [TestMethod]
        public void EqualDoubleInteger()
        {
            Assert.AreEqual((double)1.2 == (int)1, this.operators.EqualObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 == (int)2, this.operators.EqualObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 == (int)1, this.operators.EqualObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 == (int)2, this.operators.EqualObject((double)2.3, (int)2));
        }        

        [TestMethod]
        public void EqualDoubleLong()
        {
            Assert.AreEqual((double)1.2 == (long)1, this.operators.EqualObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 == (long)2, this.operators.EqualObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 == (long)1, this.operators.EqualObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 == (long)2, this.operators.EqualObject((double)2.3, (long)2));
        }        

        [TestMethod]
        public void EqualDoubleFloat()
        {
            Assert.AreEqual((double)1.2 == (float)1.2, this.operators.EqualObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 == (float)2.3, this.operators.EqualObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 == (float)1.2, this.operators.EqualObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 == (float)2.3, this.operators.EqualObject((double)2.3, (float)2.3));
        }        

        [TestMethod]
        public void EqualDoubleDouble()
        {
            Assert.AreEqual((double)1.2 == (double)1.2, this.operators.EqualObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 == (double)2.3, this.operators.EqualObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 == (double)1.2, this.operators.EqualObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 == (double)2.3, this.operators.EqualObject((double)2.3, (double)2.3));
        }        

        [TestMethod]
        public void NotEqualShortShort()
        {
            Assert.AreEqual((short)1 != (short)1, this.operators.NotEqualObject((short)1, (short)1));
            Assert.AreEqual((short)1 != (short)2, this.operators.NotEqualObject((short)1, (short)2));
            Assert.AreEqual((short)2 != (short)1, this.operators.NotEqualObject((short)2, (short)1));
            Assert.AreEqual((short)2 != (short)2, this.operators.NotEqualObject((short)2, (short)2));
        }        

        [TestMethod]
        public void NotEqualShortInteger()
        {
            Assert.AreEqual((short)1 != (int)1, this.operators.NotEqualObject((short)1, (int)1));
            Assert.AreEqual((short)1 != (int)2, this.operators.NotEqualObject((short)1, (int)2));
            Assert.AreEqual((short)2 != (int)1, this.operators.NotEqualObject((short)2, (int)1));
            Assert.AreEqual((short)2 != (int)2, this.operators.NotEqualObject((short)2, (int)2));
        }        

        [TestMethod]
        public void NotEqualShortLong()
        {
            Assert.AreEqual((short)1 != (long)1, this.operators.NotEqualObject((short)1, (long)1));
            Assert.AreEqual((short)1 != (long)2, this.operators.NotEqualObject((short)1, (long)2));
            Assert.AreEqual((short)2 != (long)1, this.operators.NotEqualObject((short)2, (long)1));
            Assert.AreEqual((short)2 != (long)2, this.operators.NotEqualObject((short)2, (long)2));
        }        

        [TestMethod]
        public void NotEqualShortFloat()
        {
            Assert.AreEqual((short)1 != (float)1.2, this.operators.NotEqualObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 != (float)2.3, this.operators.NotEqualObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 != (float)1.2, this.operators.NotEqualObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 != (float)2.3, this.operators.NotEqualObject((short)2, (float)2.3));
        }        

        [TestMethod]
        public void NotEqualShortDouble()
        {
            Assert.AreEqual((short)1 != (double)1.2, this.operators.NotEqualObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 != (double)2.3, this.operators.NotEqualObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 != (double)1.2, this.operators.NotEqualObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 != (double)2.3, this.operators.NotEqualObject((short)2, (double)2.3));
        }        

        [TestMethod]
        public void NotEqualIntegerShort()
        {
            Assert.AreEqual((int)1 != (short)1, this.operators.NotEqualObject((int)1, (short)1));
            Assert.AreEqual((int)1 != (short)2, this.operators.NotEqualObject((int)1, (short)2));
            Assert.AreEqual((int)2 != (short)1, this.operators.NotEqualObject((int)2, (short)1));
            Assert.AreEqual((int)2 != (short)2, this.operators.NotEqualObject((int)2, (short)2));
        }        

        [TestMethod]
        public void NotEqualIntegerInteger()
        {
            Assert.AreEqual((int)1 != (int)1, this.operators.NotEqualObject((int)1, (int)1));
            Assert.AreEqual((int)1 != (int)2, this.operators.NotEqualObject((int)1, (int)2));
            Assert.AreEqual((int)2 != (int)1, this.operators.NotEqualObject((int)2, (int)1));
            Assert.AreEqual((int)2 != (int)2, this.operators.NotEqualObject((int)2, (int)2));
        }        

        [TestMethod]
        public void NotEqualIntegerLong()
        {
            Assert.AreEqual((int)1 != (long)1, this.operators.NotEqualObject((int)1, (long)1));
            Assert.AreEqual((int)1 != (long)2, this.operators.NotEqualObject((int)1, (long)2));
            Assert.AreEqual((int)2 != (long)1, this.operators.NotEqualObject((int)2, (long)1));
            Assert.AreEqual((int)2 != (long)2, this.operators.NotEqualObject((int)2, (long)2));
        }        

        [TestMethod]
        public void NotEqualIntegerFloat()
        {
            Assert.AreEqual((int)1 != (float)1.2, this.operators.NotEqualObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 != (float)2.3, this.operators.NotEqualObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 != (float)1.2, this.operators.NotEqualObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 != (float)2.3, this.operators.NotEqualObject((int)2, (float)2.3));
        }        

        [TestMethod]
        public void NotEqualIntegerDouble()
        {
            Assert.AreEqual((int)1 != (double)1.2, this.operators.NotEqualObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 != (double)2.3, this.operators.NotEqualObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 != (double)1.2, this.operators.NotEqualObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 != (double)2.3, this.operators.NotEqualObject((int)2, (double)2.3));
        }        

        [TestMethod]
        public void NotEqualLongShort()
        {
            Assert.AreEqual((long)1 != (short)1, this.operators.NotEqualObject((long)1, (short)1));
            Assert.AreEqual((long)1 != (short)2, this.operators.NotEqualObject((long)1, (short)2));
            Assert.AreEqual((long)2 != (short)1, this.operators.NotEqualObject((long)2, (short)1));
            Assert.AreEqual((long)2 != (short)2, this.operators.NotEqualObject((long)2, (short)2));
        }        

        [TestMethod]
        public void NotEqualLongInteger()
        {
            Assert.AreEqual((long)1 != (int)1, this.operators.NotEqualObject((long)1, (int)1));
            Assert.AreEqual((long)1 != (int)2, this.operators.NotEqualObject((long)1, (int)2));
            Assert.AreEqual((long)2 != (int)1, this.operators.NotEqualObject((long)2, (int)1));
            Assert.AreEqual((long)2 != (int)2, this.operators.NotEqualObject((long)2, (int)2));
        }        

        [TestMethod]
        public void NotEqualLongLong()
        {
            Assert.AreEqual((long)1 != (long)1, this.operators.NotEqualObject((long)1, (long)1));
            Assert.AreEqual((long)1 != (long)2, this.operators.NotEqualObject((long)1, (long)2));
            Assert.AreEqual((long)2 != (long)1, this.operators.NotEqualObject((long)2, (long)1));
            Assert.AreEqual((long)2 != (long)2, this.operators.NotEqualObject((long)2, (long)2));
        }        

        [TestMethod]
        public void NotEqualLongFloat()
        {
            Assert.AreEqual((long)1 != (float)1.2, this.operators.NotEqualObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 != (float)2.3, this.operators.NotEqualObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 != (float)1.2, this.operators.NotEqualObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 != (float)2.3, this.operators.NotEqualObject((long)2, (float)2.3));
        }        

        [TestMethod]
        public void NotEqualLongDouble()
        {
            Assert.AreEqual((long)1 != (double)1.2, this.operators.NotEqualObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 != (double)2.3, this.operators.NotEqualObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 != (double)1.2, this.operators.NotEqualObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 != (double)2.3, this.operators.NotEqualObject((long)2, (double)2.3));
        }        

        [TestMethod]
        public void NotEqualFloatShort()
        {
            Assert.AreEqual((float)1.2 != (short)1, this.operators.NotEqualObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 != (short)2, this.operators.NotEqualObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 != (short)1, this.operators.NotEqualObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 != (short)2, this.operators.NotEqualObject((float)2.3, (short)2));
        }        

        [TestMethod]
        public void NotEqualFloatInteger()
        {
            Assert.AreEqual((float)1.2 != (int)1, this.operators.NotEqualObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 != (int)2, this.operators.NotEqualObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 != (int)1, this.operators.NotEqualObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 != (int)2, this.operators.NotEqualObject((float)2.3, (int)2));
        }        

        [TestMethod]
        public void NotEqualFloatLong()
        {
            Assert.AreEqual((float)1.2 != (long)1, this.operators.NotEqualObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 != (long)2, this.operators.NotEqualObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 != (long)1, this.operators.NotEqualObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 != (long)2, this.operators.NotEqualObject((float)2.3, (long)2));
        }        

        [TestMethod]
        public void NotEqualFloatFloat()
        {
            Assert.AreEqual((float)1.2 != (float)1.2, this.operators.NotEqualObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 != (float)2.3, this.operators.NotEqualObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 != (float)1.2, this.operators.NotEqualObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 != (float)2.3, this.operators.NotEqualObject((float)2.3, (float)2.3));
        }        

        [TestMethod]
        public void NotEqualFloatDouble()
        {
            Assert.AreEqual((float)1.2 != (double)1.2, this.operators.NotEqualObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 != (double)2.3, this.operators.NotEqualObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 != (double)1.2, this.operators.NotEqualObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 != (double)2.3, this.operators.NotEqualObject((float)2.3, (double)2.3));
        }        

        [TestMethod]
        public void NotEqualDoubleShort()
        {
            Assert.AreEqual((double)1.2 != (short)1, this.operators.NotEqualObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 != (short)2, this.operators.NotEqualObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 != (short)1, this.operators.NotEqualObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 != (short)2, this.operators.NotEqualObject((double)2.3, (short)2));
        }        

        [TestMethod]
        public void NotEqualDoubleInteger()
        {
            Assert.AreEqual((double)1.2 != (int)1, this.operators.NotEqualObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 != (int)2, this.operators.NotEqualObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 != (int)1, this.operators.NotEqualObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 != (int)2, this.operators.NotEqualObject((double)2.3, (int)2));
        }        

        [TestMethod]
        public void NotEqualDoubleLong()
        {
            Assert.AreEqual((double)1.2 != (long)1, this.operators.NotEqualObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 != (long)2, this.operators.NotEqualObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 != (long)1, this.operators.NotEqualObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 != (long)2, this.operators.NotEqualObject((double)2.3, (long)2));
        }        

        [TestMethod]
        public void NotEqualDoubleFloat()
        {
            Assert.AreEqual((double)1.2 != (float)1.2, this.operators.NotEqualObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 != (float)2.3, this.operators.NotEqualObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 != (float)1.2, this.operators.NotEqualObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 != (float)2.3, this.operators.NotEqualObject((double)2.3, (float)2.3));
        }        

        [TestMethod]
        public void NotEqualDoubleDouble()
        {
            Assert.AreEqual((double)1.2 != (double)1.2, this.operators.NotEqualObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 != (double)2.3, this.operators.NotEqualObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 != (double)1.2, this.operators.NotEqualObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 != (double)2.3, this.operators.NotEqualObject((double)2.3, (double)2.3));
        }        

        [TestMethod]
        public void GreaterShortShort()
        {
            Assert.AreEqual((short)1 > (short)1, this.operators.GreaterObject((short)1, (short)1));
            Assert.AreEqual((short)1 > (short)2, this.operators.GreaterObject((short)1, (short)2));
            Assert.AreEqual((short)2 > (short)1, this.operators.GreaterObject((short)2, (short)1));
            Assert.AreEqual((short)2 > (short)2, this.operators.GreaterObject((short)2, (short)2));
        }        

        [TestMethod]
        public void GreaterShortInteger()
        {
            Assert.AreEqual((short)1 > (int)1, this.operators.GreaterObject((short)1, (int)1));
            Assert.AreEqual((short)1 > (int)2, this.operators.GreaterObject((short)1, (int)2));
            Assert.AreEqual((short)2 > (int)1, this.operators.GreaterObject((short)2, (int)1));
            Assert.AreEqual((short)2 > (int)2, this.operators.GreaterObject((short)2, (int)2));
        }        

        [TestMethod]
        public void GreaterShortLong()
        {
            Assert.AreEqual((short)1 > (long)1, this.operators.GreaterObject((short)1, (long)1));
            Assert.AreEqual((short)1 > (long)2, this.operators.GreaterObject((short)1, (long)2));
            Assert.AreEqual((short)2 > (long)1, this.operators.GreaterObject((short)2, (long)1));
            Assert.AreEqual((short)2 > (long)2, this.operators.GreaterObject((short)2, (long)2));
        }        

        [TestMethod]
        public void GreaterShortFloat()
        {
            Assert.AreEqual((short)1 > (float)1.2, this.operators.GreaterObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 > (float)2.3, this.operators.GreaterObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 > (float)1.2, this.operators.GreaterObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 > (float)2.3, this.operators.GreaterObject((short)2, (float)2.3));
        }        

        [TestMethod]
        public void GreaterShortDouble()
        {
            Assert.AreEqual((short)1 > (double)1.2, this.operators.GreaterObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 > (double)2.3, this.operators.GreaterObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 > (double)1.2, this.operators.GreaterObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 > (double)2.3, this.operators.GreaterObject((short)2, (double)2.3));
        }        

        [TestMethod]
        public void GreaterIntegerShort()
        {
            Assert.AreEqual((int)1 > (short)1, this.operators.GreaterObject((int)1, (short)1));
            Assert.AreEqual((int)1 > (short)2, this.operators.GreaterObject((int)1, (short)2));
            Assert.AreEqual((int)2 > (short)1, this.operators.GreaterObject((int)2, (short)1));
            Assert.AreEqual((int)2 > (short)2, this.operators.GreaterObject((int)2, (short)2));
        }        

        [TestMethod]
        public void GreaterIntegerInteger()
        {
            Assert.AreEqual((int)1 > (int)1, this.operators.GreaterObject((int)1, (int)1));
            Assert.AreEqual((int)1 > (int)2, this.operators.GreaterObject((int)1, (int)2));
            Assert.AreEqual((int)2 > (int)1, this.operators.GreaterObject((int)2, (int)1));
            Assert.AreEqual((int)2 > (int)2, this.operators.GreaterObject((int)2, (int)2));
        }        

        [TestMethod]
        public void GreaterIntegerLong()
        {
            Assert.AreEqual((int)1 > (long)1, this.operators.GreaterObject((int)1, (long)1));
            Assert.AreEqual((int)1 > (long)2, this.operators.GreaterObject((int)1, (long)2));
            Assert.AreEqual((int)2 > (long)1, this.operators.GreaterObject((int)2, (long)1));
            Assert.AreEqual((int)2 > (long)2, this.operators.GreaterObject((int)2, (long)2));
        }        

        [TestMethod]
        public void GreaterIntegerFloat()
        {
            Assert.AreEqual((int)1 > (float)1.2, this.operators.GreaterObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 > (float)2.3, this.operators.GreaterObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 > (float)1.2, this.operators.GreaterObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 > (float)2.3, this.operators.GreaterObject((int)2, (float)2.3));
        }        

        [TestMethod]
        public void GreaterIntegerDouble()
        {
            Assert.AreEqual((int)1 > (double)1.2, this.operators.GreaterObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 > (double)2.3, this.operators.GreaterObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 > (double)1.2, this.operators.GreaterObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 > (double)2.3, this.operators.GreaterObject((int)2, (double)2.3));
        }        

        [TestMethod]
        public void GreaterLongShort()
        {
            Assert.AreEqual((long)1 > (short)1, this.operators.GreaterObject((long)1, (short)1));
            Assert.AreEqual((long)1 > (short)2, this.operators.GreaterObject((long)1, (short)2));
            Assert.AreEqual((long)2 > (short)1, this.operators.GreaterObject((long)2, (short)1));
            Assert.AreEqual((long)2 > (short)2, this.operators.GreaterObject((long)2, (short)2));
        }        

        [TestMethod]
        public void GreaterLongInteger()
        {
            Assert.AreEqual((long)1 > (int)1, this.operators.GreaterObject((long)1, (int)1));
            Assert.AreEqual((long)1 > (int)2, this.operators.GreaterObject((long)1, (int)2));
            Assert.AreEqual((long)2 > (int)1, this.operators.GreaterObject((long)2, (int)1));
            Assert.AreEqual((long)2 > (int)2, this.operators.GreaterObject((long)2, (int)2));
        }        

        [TestMethod]
        public void GreaterLongLong()
        {
            Assert.AreEqual((long)1 > (long)1, this.operators.GreaterObject((long)1, (long)1));
            Assert.AreEqual((long)1 > (long)2, this.operators.GreaterObject((long)1, (long)2));
            Assert.AreEqual((long)2 > (long)1, this.operators.GreaterObject((long)2, (long)1));
            Assert.AreEqual((long)2 > (long)2, this.operators.GreaterObject((long)2, (long)2));
        }        

        [TestMethod]
        public void GreaterLongFloat()
        {
            Assert.AreEqual((long)1 > (float)1.2, this.operators.GreaterObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 > (float)2.3, this.operators.GreaterObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 > (float)1.2, this.operators.GreaterObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 > (float)2.3, this.operators.GreaterObject((long)2, (float)2.3));
        }        

        [TestMethod]
        public void GreaterLongDouble()
        {
            Assert.AreEqual((long)1 > (double)1.2, this.operators.GreaterObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 > (double)2.3, this.operators.GreaterObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 > (double)1.2, this.operators.GreaterObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 > (double)2.3, this.operators.GreaterObject((long)2, (double)2.3));
        }        

        [TestMethod]
        public void GreaterFloatShort()
        {
            Assert.AreEqual((float)1.2 > (short)1, this.operators.GreaterObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 > (short)2, this.operators.GreaterObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 > (short)1, this.operators.GreaterObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 > (short)2, this.operators.GreaterObject((float)2.3, (short)2));
        }        

        [TestMethod]
        public void GreaterFloatInteger()
        {
            Assert.AreEqual((float)1.2 > (int)1, this.operators.GreaterObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 > (int)2, this.operators.GreaterObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 > (int)1, this.operators.GreaterObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 > (int)2, this.operators.GreaterObject((float)2.3, (int)2));
        }        

        [TestMethod]
        public void GreaterFloatLong()
        {
            Assert.AreEqual((float)1.2 > (long)1, this.operators.GreaterObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 > (long)2, this.operators.GreaterObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 > (long)1, this.operators.GreaterObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 > (long)2, this.operators.GreaterObject((float)2.3, (long)2));
        }        

        [TestMethod]
        public void GreaterFloatFloat()
        {
            Assert.AreEqual((float)1.2 > (float)1.2, this.operators.GreaterObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 > (float)2.3, this.operators.GreaterObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 > (float)1.2, this.operators.GreaterObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 > (float)2.3, this.operators.GreaterObject((float)2.3, (float)2.3));
        }        

        [TestMethod]
        public void GreaterFloatDouble()
        {
            Assert.AreEqual((float)1.2 > (double)1.2, this.operators.GreaterObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 > (double)2.3, this.operators.GreaterObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 > (double)1.2, this.operators.GreaterObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 > (double)2.3, this.operators.GreaterObject((float)2.3, (double)2.3));
        }        

        [TestMethod]
        public void GreaterDoubleShort()
        {
            Assert.AreEqual((double)1.2 > (short)1, this.operators.GreaterObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 > (short)2, this.operators.GreaterObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 > (short)1, this.operators.GreaterObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 > (short)2, this.operators.GreaterObject((double)2.3, (short)2));
        }        

        [TestMethod]
        public void GreaterDoubleInteger()
        {
            Assert.AreEqual((double)1.2 > (int)1, this.operators.GreaterObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 > (int)2, this.operators.GreaterObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 > (int)1, this.operators.GreaterObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 > (int)2, this.operators.GreaterObject((double)2.3, (int)2));
        }        

        [TestMethod]
        public void GreaterDoubleLong()
        {
            Assert.AreEqual((double)1.2 > (long)1, this.operators.GreaterObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 > (long)2, this.operators.GreaterObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 > (long)1, this.operators.GreaterObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 > (long)2, this.operators.GreaterObject((double)2.3, (long)2));
        }        

        [TestMethod]
        public void GreaterDoubleFloat()
        {
            Assert.AreEqual((double)1.2 > (float)1.2, this.operators.GreaterObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 > (float)2.3, this.operators.GreaterObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 > (float)1.2, this.operators.GreaterObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 > (float)2.3, this.operators.GreaterObject((double)2.3, (float)2.3));
        }        

        [TestMethod]
        public void GreaterDoubleDouble()
        {
            Assert.AreEqual((double)1.2 > (double)1.2, this.operators.GreaterObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 > (double)2.3, this.operators.GreaterObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 > (double)1.2, this.operators.GreaterObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 > (double)2.3, this.operators.GreaterObject((double)2.3, (double)2.3));
        }        

        [TestMethod]
        public void GreaterEqualShortShort()
        {
            Assert.AreEqual((short)1 >= (short)1, this.operators.GreaterEqualObject((short)1, (short)1));
            Assert.AreEqual((short)1 >= (short)2, this.operators.GreaterEqualObject((short)1, (short)2));
            Assert.AreEqual((short)2 >= (short)1, this.operators.GreaterEqualObject((short)2, (short)1));
            Assert.AreEqual((short)2 >= (short)2, this.operators.GreaterEqualObject((short)2, (short)2));
        }        

        [TestMethod]
        public void GreaterEqualShortInteger()
        {
            Assert.AreEqual((short)1 >= (int)1, this.operators.GreaterEqualObject((short)1, (int)1));
            Assert.AreEqual((short)1 >= (int)2, this.operators.GreaterEqualObject((short)1, (int)2));
            Assert.AreEqual((short)2 >= (int)1, this.operators.GreaterEqualObject((short)2, (int)1));
            Assert.AreEqual((short)2 >= (int)2, this.operators.GreaterEqualObject((short)2, (int)2));
        }        

        [TestMethod]
        public void GreaterEqualShortLong()
        {
            Assert.AreEqual((short)1 >= (long)1, this.operators.GreaterEqualObject((short)1, (long)1));
            Assert.AreEqual((short)1 >= (long)2, this.operators.GreaterEqualObject((short)1, (long)2));
            Assert.AreEqual((short)2 >= (long)1, this.operators.GreaterEqualObject((short)2, (long)1));
            Assert.AreEqual((short)2 >= (long)2, this.operators.GreaterEqualObject((short)2, (long)2));
        }        

        [TestMethod]
        public void GreaterEqualShortFloat()
        {
            Assert.AreEqual((short)1 >= (float)1.2, this.operators.GreaterEqualObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 >= (float)2.3, this.operators.GreaterEqualObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 >= (float)1.2, this.operators.GreaterEqualObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 >= (float)2.3, this.operators.GreaterEqualObject((short)2, (float)2.3));
        }        

        [TestMethod]
        public void GreaterEqualShortDouble()
        {
            Assert.AreEqual((short)1 >= (double)1.2, this.operators.GreaterEqualObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 >= (double)2.3, this.operators.GreaterEqualObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 >= (double)1.2, this.operators.GreaterEqualObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 >= (double)2.3, this.operators.GreaterEqualObject((short)2, (double)2.3));
        }        

        [TestMethod]
        public void GreaterEqualIntegerShort()
        {
            Assert.AreEqual((int)1 >= (short)1, this.operators.GreaterEqualObject((int)1, (short)1));
            Assert.AreEqual((int)1 >= (short)2, this.operators.GreaterEqualObject((int)1, (short)2));
            Assert.AreEqual((int)2 >= (short)1, this.operators.GreaterEqualObject((int)2, (short)1));
            Assert.AreEqual((int)2 >= (short)2, this.operators.GreaterEqualObject((int)2, (short)2));
        }        

        [TestMethod]
        public void GreaterEqualIntegerInteger()
        {
            Assert.AreEqual((int)1 >= (int)1, this.operators.GreaterEqualObject((int)1, (int)1));
            Assert.AreEqual((int)1 >= (int)2, this.operators.GreaterEqualObject((int)1, (int)2));
            Assert.AreEqual((int)2 >= (int)1, this.operators.GreaterEqualObject((int)2, (int)1));
            Assert.AreEqual((int)2 >= (int)2, this.operators.GreaterEqualObject((int)2, (int)2));
        }        

        [TestMethod]
        public void GreaterEqualIntegerLong()
        {
            Assert.AreEqual((int)1 >= (long)1, this.operators.GreaterEqualObject((int)1, (long)1));
            Assert.AreEqual((int)1 >= (long)2, this.operators.GreaterEqualObject((int)1, (long)2));
            Assert.AreEqual((int)2 >= (long)1, this.operators.GreaterEqualObject((int)2, (long)1));
            Assert.AreEqual((int)2 >= (long)2, this.operators.GreaterEqualObject((int)2, (long)2));
        }        

        [TestMethod]
        public void GreaterEqualIntegerFloat()
        {
            Assert.AreEqual((int)1 >= (float)1.2, this.operators.GreaterEqualObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 >= (float)2.3, this.operators.GreaterEqualObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 >= (float)1.2, this.operators.GreaterEqualObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 >= (float)2.3, this.operators.GreaterEqualObject((int)2, (float)2.3));
        }        

        [TestMethod]
        public void GreaterEqualIntegerDouble()
        {
            Assert.AreEqual((int)1 >= (double)1.2, this.operators.GreaterEqualObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 >= (double)2.3, this.operators.GreaterEqualObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 >= (double)1.2, this.operators.GreaterEqualObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 >= (double)2.3, this.operators.GreaterEqualObject((int)2, (double)2.3));
        }        

        [TestMethod]
        public void GreaterEqualLongShort()
        {
            Assert.AreEqual((long)1 >= (short)1, this.operators.GreaterEqualObject((long)1, (short)1));
            Assert.AreEqual((long)1 >= (short)2, this.operators.GreaterEqualObject((long)1, (short)2));
            Assert.AreEqual((long)2 >= (short)1, this.operators.GreaterEqualObject((long)2, (short)1));
            Assert.AreEqual((long)2 >= (short)2, this.operators.GreaterEqualObject((long)2, (short)2));
        }        

        [TestMethod]
        public void GreaterEqualLongInteger()
        {
            Assert.AreEqual((long)1 >= (int)1, this.operators.GreaterEqualObject((long)1, (int)1));
            Assert.AreEqual((long)1 >= (int)2, this.operators.GreaterEqualObject((long)1, (int)2));
            Assert.AreEqual((long)2 >= (int)1, this.operators.GreaterEqualObject((long)2, (int)1));
            Assert.AreEqual((long)2 >= (int)2, this.operators.GreaterEqualObject((long)2, (int)2));
        }        

        [TestMethod]
        public void GreaterEqualLongLong()
        {
            Assert.AreEqual((long)1 >= (long)1, this.operators.GreaterEqualObject((long)1, (long)1));
            Assert.AreEqual((long)1 >= (long)2, this.operators.GreaterEqualObject((long)1, (long)2));
            Assert.AreEqual((long)2 >= (long)1, this.operators.GreaterEqualObject((long)2, (long)1));
            Assert.AreEqual((long)2 >= (long)2, this.operators.GreaterEqualObject((long)2, (long)2));
        }        

        [TestMethod]
        public void GreaterEqualLongFloat()
        {
            Assert.AreEqual((long)1 >= (float)1.2, this.operators.GreaterEqualObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 >= (float)2.3, this.operators.GreaterEqualObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 >= (float)1.2, this.operators.GreaterEqualObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 >= (float)2.3, this.operators.GreaterEqualObject((long)2, (float)2.3));
        }        

        [TestMethod]
        public void GreaterEqualLongDouble()
        {
            Assert.AreEqual((long)1 >= (double)1.2, this.operators.GreaterEqualObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 >= (double)2.3, this.operators.GreaterEqualObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 >= (double)1.2, this.operators.GreaterEqualObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 >= (double)2.3, this.operators.GreaterEqualObject((long)2, (double)2.3));
        }        

        [TestMethod]
        public void GreaterEqualFloatShort()
        {
            Assert.AreEqual((float)1.2 >= (short)1, this.operators.GreaterEqualObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 >= (short)2, this.operators.GreaterEqualObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 >= (short)1, this.operators.GreaterEqualObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 >= (short)2, this.operators.GreaterEqualObject((float)2.3, (short)2));
        }        

        [TestMethod]
        public void GreaterEqualFloatInteger()
        {
            Assert.AreEqual((float)1.2 >= (int)1, this.operators.GreaterEqualObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 >= (int)2, this.operators.GreaterEqualObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 >= (int)1, this.operators.GreaterEqualObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 >= (int)2, this.operators.GreaterEqualObject((float)2.3, (int)2));
        }        

        [TestMethod]
        public void GreaterEqualFloatLong()
        {
            Assert.AreEqual((float)1.2 >= (long)1, this.operators.GreaterEqualObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 >= (long)2, this.operators.GreaterEqualObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 >= (long)1, this.operators.GreaterEqualObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 >= (long)2, this.operators.GreaterEqualObject((float)2.3, (long)2));
        }        

        [TestMethod]
        public void GreaterEqualFloatFloat()
        {
            Assert.AreEqual((float)1.2 >= (float)1.2, this.operators.GreaterEqualObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 >= (float)2.3, this.operators.GreaterEqualObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 >= (float)1.2, this.operators.GreaterEqualObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 >= (float)2.3, this.operators.GreaterEqualObject((float)2.3, (float)2.3));
        }        

        [TestMethod]
        public void GreaterEqualFloatDouble()
        {
            Assert.AreEqual((float)1.2 >= (double)1.2, this.operators.GreaterEqualObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 >= (double)2.3, this.operators.GreaterEqualObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 >= (double)1.2, this.operators.GreaterEqualObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 >= (double)2.3, this.operators.GreaterEqualObject((float)2.3, (double)2.3));
        }        

        [TestMethod]
        public void GreaterEqualDoubleShort()
        {
            Assert.AreEqual((double)1.2 >= (short)1, this.operators.GreaterEqualObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 >= (short)2, this.operators.GreaterEqualObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 >= (short)1, this.operators.GreaterEqualObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 >= (short)2, this.operators.GreaterEqualObject((double)2.3, (short)2));
        }        

        [TestMethod]
        public void GreaterEqualDoubleInteger()
        {
            Assert.AreEqual((double)1.2 >= (int)1, this.operators.GreaterEqualObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 >= (int)2, this.operators.GreaterEqualObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 >= (int)1, this.operators.GreaterEqualObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 >= (int)2, this.operators.GreaterEqualObject((double)2.3, (int)2));
        }        

        [TestMethod]
        public void GreaterEqualDoubleLong()
        {
            Assert.AreEqual((double)1.2 >= (long)1, this.operators.GreaterEqualObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 >= (long)2, this.operators.GreaterEqualObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 >= (long)1, this.operators.GreaterEqualObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 >= (long)2, this.operators.GreaterEqualObject((double)2.3, (long)2));
        }        

        [TestMethod]
        public void GreaterEqualDoubleFloat()
        {
            Assert.AreEqual((double)1.2 >= (float)1.2, this.operators.GreaterEqualObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 >= (float)2.3, this.operators.GreaterEqualObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 >= (float)1.2, this.operators.GreaterEqualObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 >= (float)2.3, this.operators.GreaterEqualObject((double)2.3, (float)2.3));
        }        

        [TestMethod]
        public void GreaterEqualDoubleDouble()
        {
            Assert.AreEqual((double)1.2 >= (double)1.2, this.operators.GreaterEqualObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 >= (double)2.3, this.operators.GreaterEqualObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 >= (double)1.2, this.operators.GreaterEqualObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 >= (double)2.3, this.operators.GreaterEqualObject((double)2.3, (double)2.3));
        }        

        [TestMethod]
        public void LessShortShort()
        {
            Assert.AreEqual((short)1 < (short)1, this.operators.LessObject((short)1, (short)1));
            Assert.AreEqual((short)1 < (short)2, this.operators.LessObject((short)1, (short)2));
            Assert.AreEqual((short)2 < (short)1, this.operators.LessObject((short)2, (short)1));
            Assert.AreEqual((short)2 < (short)2, this.operators.LessObject((short)2, (short)2));
        }        

        [TestMethod]
        public void LessShortInteger()
        {
            Assert.AreEqual((short)1 < (int)1, this.operators.LessObject((short)1, (int)1));
            Assert.AreEqual((short)1 < (int)2, this.operators.LessObject((short)1, (int)2));
            Assert.AreEqual((short)2 < (int)1, this.operators.LessObject((short)2, (int)1));
            Assert.AreEqual((short)2 < (int)2, this.operators.LessObject((short)2, (int)2));
        }        

        [TestMethod]
        public void LessShortLong()
        {
            Assert.AreEqual((short)1 < (long)1, this.operators.LessObject((short)1, (long)1));
            Assert.AreEqual((short)1 < (long)2, this.operators.LessObject((short)1, (long)2));
            Assert.AreEqual((short)2 < (long)1, this.operators.LessObject((short)2, (long)1));
            Assert.AreEqual((short)2 < (long)2, this.operators.LessObject((short)2, (long)2));
        }        

        [TestMethod]
        public void LessShortFloat()
        {
            Assert.AreEqual((short)1 < (float)1.2, this.operators.LessObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 < (float)2.3, this.operators.LessObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 < (float)1.2, this.operators.LessObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 < (float)2.3, this.operators.LessObject((short)2, (float)2.3));
        }        

        [TestMethod]
        public void LessShortDouble()
        {
            Assert.AreEqual((short)1 < (double)1.2, this.operators.LessObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 < (double)2.3, this.operators.LessObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 < (double)1.2, this.operators.LessObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 < (double)2.3, this.operators.LessObject((short)2, (double)2.3));
        }        

        [TestMethod]
        public void LessIntegerShort()
        {
            Assert.AreEqual((int)1 < (short)1, this.operators.LessObject((int)1, (short)1));
            Assert.AreEqual((int)1 < (short)2, this.operators.LessObject((int)1, (short)2));
            Assert.AreEqual((int)2 < (short)1, this.operators.LessObject((int)2, (short)1));
            Assert.AreEqual((int)2 < (short)2, this.operators.LessObject((int)2, (short)2));
        }        

        [TestMethod]
        public void LessIntegerInteger()
        {
            Assert.AreEqual((int)1 < (int)1, this.operators.LessObject((int)1, (int)1));
            Assert.AreEqual((int)1 < (int)2, this.operators.LessObject((int)1, (int)2));
            Assert.AreEqual((int)2 < (int)1, this.operators.LessObject((int)2, (int)1));
            Assert.AreEqual((int)2 < (int)2, this.operators.LessObject((int)2, (int)2));
        }        

        [TestMethod]
        public void LessIntegerLong()
        {
            Assert.AreEqual((int)1 < (long)1, this.operators.LessObject((int)1, (long)1));
            Assert.AreEqual((int)1 < (long)2, this.operators.LessObject((int)1, (long)2));
            Assert.AreEqual((int)2 < (long)1, this.operators.LessObject((int)2, (long)1));
            Assert.AreEqual((int)2 < (long)2, this.operators.LessObject((int)2, (long)2));
        }        

        [TestMethod]
        public void LessIntegerFloat()
        {
            Assert.AreEqual((int)1 < (float)1.2, this.operators.LessObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 < (float)2.3, this.operators.LessObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 < (float)1.2, this.operators.LessObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 < (float)2.3, this.operators.LessObject((int)2, (float)2.3));
        }        

        [TestMethod]
        public void LessIntegerDouble()
        {
            Assert.AreEqual((int)1 < (double)1.2, this.operators.LessObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 < (double)2.3, this.operators.LessObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 < (double)1.2, this.operators.LessObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 < (double)2.3, this.operators.LessObject((int)2, (double)2.3));
        }        

        [TestMethod]
        public void LessLongShort()
        {
            Assert.AreEqual((long)1 < (short)1, this.operators.LessObject((long)1, (short)1));
            Assert.AreEqual((long)1 < (short)2, this.operators.LessObject((long)1, (short)2));
            Assert.AreEqual((long)2 < (short)1, this.operators.LessObject((long)2, (short)1));
            Assert.AreEqual((long)2 < (short)2, this.operators.LessObject((long)2, (short)2));
        }        

        [TestMethod]
        public void LessLongInteger()
        {
            Assert.AreEqual((long)1 < (int)1, this.operators.LessObject((long)1, (int)1));
            Assert.AreEqual((long)1 < (int)2, this.operators.LessObject((long)1, (int)2));
            Assert.AreEqual((long)2 < (int)1, this.operators.LessObject((long)2, (int)1));
            Assert.AreEqual((long)2 < (int)2, this.operators.LessObject((long)2, (int)2));
        }        

        [TestMethod]
        public void LessLongLong()
        {
            Assert.AreEqual((long)1 < (long)1, this.operators.LessObject((long)1, (long)1));
            Assert.AreEqual((long)1 < (long)2, this.operators.LessObject((long)1, (long)2));
            Assert.AreEqual((long)2 < (long)1, this.operators.LessObject((long)2, (long)1));
            Assert.AreEqual((long)2 < (long)2, this.operators.LessObject((long)2, (long)2));
        }        

        [TestMethod]
        public void LessLongFloat()
        {
            Assert.AreEqual((long)1 < (float)1.2, this.operators.LessObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 < (float)2.3, this.operators.LessObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 < (float)1.2, this.operators.LessObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 < (float)2.3, this.operators.LessObject((long)2, (float)2.3));
        }        

        [TestMethod]
        public void LessLongDouble()
        {
            Assert.AreEqual((long)1 < (double)1.2, this.operators.LessObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 < (double)2.3, this.operators.LessObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 < (double)1.2, this.operators.LessObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 < (double)2.3, this.operators.LessObject((long)2, (double)2.3));
        }        

        [TestMethod]
        public void LessFloatShort()
        {
            Assert.AreEqual((float)1.2 < (short)1, this.operators.LessObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 < (short)2, this.operators.LessObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 < (short)1, this.operators.LessObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 < (short)2, this.operators.LessObject((float)2.3, (short)2));
        }        

        [TestMethod]
        public void LessFloatInteger()
        {
            Assert.AreEqual((float)1.2 < (int)1, this.operators.LessObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 < (int)2, this.operators.LessObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 < (int)1, this.operators.LessObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 < (int)2, this.operators.LessObject((float)2.3, (int)2));
        }        

        [TestMethod]
        public void LessFloatLong()
        {
            Assert.AreEqual((float)1.2 < (long)1, this.operators.LessObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 < (long)2, this.operators.LessObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 < (long)1, this.operators.LessObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 < (long)2, this.operators.LessObject((float)2.3, (long)2));
        }        

        [TestMethod]
        public void LessFloatFloat()
        {
            Assert.AreEqual((float)1.2 < (float)1.2, this.operators.LessObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 < (float)2.3, this.operators.LessObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 < (float)1.2, this.operators.LessObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 < (float)2.3, this.operators.LessObject((float)2.3, (float)2.3));
        }        

        [TestMethod]
        public void LessFloatDouble()
        {
            Assert.AreEqual((float)1.2 < (double)1.2, this.operators.LessObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 < (double)2.3, this.operators.LessObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 < (double)1.2, this.operators.LessObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 < (double)2.3, this.operators.LessObject((float)2.3, (double)2.3));
        }        

        [TestMethod]
        public void LessDoubleShort()
        {
            Assert.AreEqual((double)1.2 < (short)1, this.operators.LessObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 < (short)2, this.operators.LessObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 < (short)1, this.operators.LessObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 < (short)2, this.operators.LessObject((double)2.3, (short)2));
        }        

        [TestMethod]
        public void LessDoubleInteger()
        {
            Assert.AreEqual((double)1.2 < (int)1, this.operators.LessObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 < (int)2, this.operators.LessObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 < (int)1, this.operators.LessObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 < (int)2, this.operators.LessObject((double)2.3, (int)2));
        }        

        [TestMethod]
        public void LessDoubleLong()
        {
            Assert.AreEqual((double)1.2 < (long)1, this.operators.LessObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 < (long)2, this.operators.LessObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 < (long)1, this.operators.LessObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 < (long)2, this.operators.LessObject((double)2.3, (long)2));
        }        

        [TestMethod]
        public void LessDoubleFloat()
        {
            Assert.AreEqual((double)1.2 < (float)1.2, this.operators.LessObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 < (float)2.3, this.operators.LessObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 < (float)1.2, this.operators.LessObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 < (float)2.3, this.operators.LessObject((double)2.3, (float)2.3));
        }        

        [TestMethod]
        public void LessDoubleDouble()
        {
            Assert.AreEqual((double)1.2 < (double)1.2, this.operators.LessObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 < (double)2.3, this.operators.LessObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 < (double)1.2, this.operators.LessObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 < (double)2.3, this.operators.LessObject((double)2.3, (double)2.3));
        }        

        [TestMethod]
        public void LessEqualShortShort()
        {
            Assert.AreEqual((short)1 <= (short)1, this.operators.LessEqualObject((short)1, (short)1));
            Assert.AreEqual((short)1 <= (short)2, this.operators.LessEqualObject((short)1, (short)2));
            Assert.AreEqual((short)2 <= (short)1, this.operators.LessEqualObject((short)2, (short)1));
            Assert.AreEqual((short)2 <= (short)2, this.operators.LessEqualObject((short)2, (short)2));
        }        

        [TestMethod]
        public void LessEqualShortInteger()
        {
            Assert.AreEqual((short)1 <= (int)1, this.operators.LessEqualObject((short)1, (int)1));
            Assert.AreEqual((short)1 <= (int)2, this.operators.LessEqualObject((short)1, (int)2));
            Assert.AreEqual((short)2 <= (int)1, this.operators.LessEqualObject((short)2, (int)1));
            Assert.AreEqual((short)2 <= (int)2, this.operators.LessEqualObject((short)2, (int)2));
        }        

        [TestMethod]
        public void LessEqualShortLong()
        {
            Assert.AreEqual((short)1 <= (long)1, this.operators.LessEqualObject((short)1, (long)1));
            Assert.AreEqual((short)1 <= (long)2, this.operators.LessEqualObject((short)1, (long)2));
            Assert.AreEqual((short)2 <= (long)1, this.operators.LessEqualObject((short)2, (long)1));
            Assert.AreEqual((short)2 <= (long)2, this.operators.LessEqualObject((short)2, (long)2));
        }        

        [TestMethod]
        public void LessEqualShortFloat()
        {
            Assert.AreEqual((short)1 <= (float)1.2, this.operators.LessEqualObject((short)1, (float)1.2));
            Assert.AreEqual((short)1 <= (float)2.3, this.operators.LessEqualObject((short)1, (float)2.3));
            Assert.AreEqual((short)2 <= (float)1.2, this.operators.LessEqualObject((short)2, (float)1.2));
            Assert.AreEqual((short)2 <= (float)2.3, this.operators.LessEqualObject((short)2, (float)2.3));
        }        

        [TestMethod]
        public void LessEqualShortDouble()
        {
            Assert.AreEqual((short)1 <= (double)1.2, this.operators.LessEqualObject((short)1, (double)1.2));
            Assert.AreEqual((short)1 <= (double)2.3, this.operators.LessEqualObject((short)1, (double)2.3));
            Assert.AreEqual((short)2 <= (double)1.2, this.operators.LessEqualObject((short)2, (double)1.2));
            Assert.AreEqual((short)2 <= (double)2.3, this.operators.LessEqualObject((short)2, (double)2.3));
        }        

        [TestMethod]
        public void LessEqualIntegerShort()
        {
            Assert.AreEqual((int)1 <= (short)1, this.operators.LessEqualObject((int)1, (short)1));
            Assert.AreEqual((int)1 <= (short)2, this.operators.LessEqualObject((int)1, (short)2));
            Assert.AreEqual((int)2 <= (short)1, this.operators.LessEqualObject((int)2, (short)1));
            Assert.AreEqual((int)2 <= (short)2, this.operators.LessEqualObject((int)2, (short)2));
        }        

        [TestMethod]
        public void LessEqualIntegerInteger()
        {
            Assert.AreEqual((int)1 <= (int)1, this.operators.LessEqualObject((int)1, (int)1));
            Assert.AreEqual((int)1 <= (int)2, this.operators.LessEqualObject((int)1, (int)2));
            Assert.AreEqual((int)2 <= (int)1, this.operators.LessEqualObject((int)2, (int)1));
            Assert.AreEqual((int)2 <= (int)2, this.operators.LessEqualObject((int)2, (int)2));
        }        

        [TestMethod]
        public void LessEqualIntegerLong()
        {
            Assert.AreEqual((int)1 <= (long)1, this.operators.LessEqualObject((int)1, (long)1));
            Assert.AreEqual((int)1 <= (long)2, this.operators.LessEqualObject((int)1, (long)2));
            Assert.AreEqual((int)2 <= (long)1, this.operators.LessEqualObject((int)2, (long)1));
            Assert.AreEqual((int)2 <= (long)2, this.operators.LessEqualObject((int)2, (long)2));
        }        

        [TestMethod]
        public void LessEqualIntegerFloat()
        {
            Assert.AreEqual((int)1 <= (float)1.2, this.operators.LessEqualObject((int)1, (float)1.2));
            Assert.AreEqual((int)1 <= (float)2.3, this.operators.LessEqualObject((int)1, (float)2.3));
            Assert.AreEqual((int)2 <= (float)1.2, this.operators.LessEqualObject((int)2, (float)1.2));
            Assert.AreEqual((int)2 <= (float)2.3, this.operators.LessEqualObject((int)2, (float)2.3));
        }        

        [TestMethod]
        public void LessEqualIntegerDouble()
        {
            Assert.AreEqual((int)1 <= (double)1.2, this.operators.LessEqualObject((int)1, (double)1.2));
            Assert.AreEqual((int)1 <= (double)2.3, this.operators.LessEqualObject((int)1, (double)2.3));
            Assert.AreEqual((int)2 <= (double)1.2, this.operators.LessEqualObject((int)2, (double)1.2));
            Assert.AreEqual((int)2 <= (double)2.3, this.operators.LessEqualObject((int)2, (double)2.3));
        }        

        [TestMethod]
        public void LessEqualLongShort()
        {
            Assert.AreEqual((long)1 <= (short)1, this.operators.LessEqualObject((long)1, (short)1));
            Assert.AreEqual((long)1 <= (short)2, this.operators.LessEqualObject((long)1, (short)2));
            Assert.AreEqual((long)2 <= (short)1, this.operators.LessEqualObject((long)2, (short)1));
            Assert.AreEqual((long)2 <= (short)2, this.operators.LessEqualObject((long)2, (short)2));
        }        

        [TestMethod]
        public void LessEqualLongInteger()
        {
            Assert.AreEqual((long)1 <= (int)1, this.operators.LessEqualObject((long)1, (int)1));
            Assert.AreEqual((long)1 <= (int)2, this.operators.LessEqualObject((long)1, (int)2));
            Assert.AreEqual((long)2 <= (int)1, this.operators.LessEqualObject((long)2, (int)1));
            Assert.AreEqual((long)2 <= (int)2, this.operators.LessEqualObject((long)2, (int)2));
        }        

        [TestMethod]
        public void LessEqualLongLong()
        {
            Assert.AreEqual((long)1 <= (long)1, this.operators.LessEqualObject((long)1, (long)1));
            Assert.AreEqual((long)1 <= (long)2, this.operators.LessEqualObject((long)1, (long)2));
            Assert.AreEqual((long)2 <= (long)1, this.operators.LessEqualObject((long)2, (long)1));
            Assert.AreEqual((long)2 <= (long)2, this.operators.LessEqualObject((long)2, (long)2));
        }        

        [TestMethod]
        public void LessEqualLongFloat()
        {
            Assert.AreEqual((long)1 <= (float)1.2, this.operators.LessEqualObject((long)1, (float)1.2));
            Assert.AreEqual((long)1 <= (float)2.3, this.operators.LessEqualObject((long)1, (float)2.3));
            Assert.AreEqual((long)2 <= (float)1.2, this.operators.LessEqualObject((long)2, (float)1.2));
            Assert.AreEqual((long)2 <= (float)2.3, this.operators.LessEqualObject((long)2, (float)2.3));
        }        

        [TestMethod]
        public void LessEqualLongDouble()
        {
            Assert.AreEqual((long)1 <= (double)1.2, this.operators.LessEqualObject((long)1, (double)1.2));
            Assert.AreEqual((long)1 <= (double)2.3, this.operators.LessEqualObject((long)1, (double)2.3));
            Assert.AreEqual((long)2 <= (double)1.2, this.operators.LessEqualObject((long)2, (double)1.2));
            Assert.AreEqual((long)2 <= (double)2.3, this.operators.LessEqualObject((long)2, (double)2.3));
        }        

        [TestMethod]
        public void LessEqualFloatShort()
        {
            Assert.AreEqual((float)1.2 <= (short)1, this.operators.LessEqualObject((float)1.2, (short)1));
            Assert.AreEqual((float)1.2 <= (short)2, this.operators.LessEqualObject((float)1.2, (short)2));
            Assert.AreEqual((float)2.3 <= (short)1, this.operators.LessEqualObject((float)2.3, (short)1));
            Assert.AreEqual((float)2.3 <= (short)2, this.operators.LessEqualObject((float)2.3, (short)2));
        }        

        [TestMethod]
        public void LessEqualFloatInteger()
        {
            Assert.AreEqual((float)1.2 <= (int)1, this.operators.LessEqualObject((float)1.2, (int)1));
            Assert.AreEqual((float)1.2 <= (int)2, this.operators.LessEqualObject((float)1.2, (int)2));
            Assert.AreEqual((float)2.3 <= (int)1, this.operators.LessEqualObject((float)2.3, (int)1));
            Assert.AreEqual((float)2.3 <= (int)2, this.operators.LessEqualObject((float)2.3, (int)2));
        }        

        [TestMethod]
        public void LessEqualFloatLong()
        {
            Assert.AreEqual((float)1.2 <= (long)1, this.operators.LessEqualObject((float)1.2, (long)1));
            Assert.AreEqual((float)1.2 <= (long)2, this.operators.LessEqualObject((float)1.2, (long)2));
            Assert.AreEqual((float)2.3 <= (long)1, this.operators.LessEqualObject((float)2.3, (long)1));
            Assert.AreEqual((float)2.3 <= (long)2, this.operators.LessEqualObject((float)2.3, (long)2));
        }        

        [TestMethod]
        public void LessEqualFloatFloat()
        {
            Assert.AreEqual((float)1.2 <= (float)1.2, this.operators.LessEqualObject((float)1.2, (float)1.2));
            Assert.AreEqual((float)1.2 <= (float)2.3, this.operators.LessEqualObject((float)1.2, (float)2.3));
            Assert.AreEqual((float)2.3 <= (float)1.2, this.operators.LessEqualObject((float)2.3, (float)1.2));
            Assert.AreEqual((float)2.3 <= (float)2.3, this.operators.LessEqualObject((float)2.3, (float)2.3));
        }        

        [TestMethod]
        public void LessEqualFloatDouble()
        {
            Assert.AreEqual((float)1.2 <= (double)1.2, this.operators.LessEqualObject((float)1.2, (double)1.2));
            Assert.AreEqual((float)1.2 <= (double)2.3, this.operators.LessEqualObject((float)1.2, (double)2.3));
            Assert.AreEqual((float)2.3 <= (double)1.2, this.operators.LessEqualObject((float)2.3, (double)1.2));
            Assert.AreEqual((float)2.3 <= (double)2.3, this.operators.LessEqualObject((float)2.3, (double)2.3));
        }        

        [TestMethod]
        public void LessEqualDoubleShort()
        {
            Assert.AreEqual((double)1.2 <= (short)1, this.operators.LessEqualObject((double)1.2, (short)1));
            Assert.AreEqual((double)1.2 <= (short)2, this.operators.LessEqualObject((double)1.2, (short)2));
            Assert.AreEqual((double)2.3 <= (short)1, this.operators.LessEqualObject((double)2.3, (short)1));
            Assert.AreEqual((double)2.3 <= (short)2, this.operators.LessEqualObject((double)2.3, (short)2));
        }        

        [TestMethod]
        public void LessEqualDoubleInteger()
        {
            Assert.AreEqual((double)1.2 <= (int)1, this.operators.LessEqualObject((double)1.2, (int)1));
            Assert.AreEqual((double)1.2 <= (int)2, this.operators.LessEqualObject((double)1.2, (int)2));
            Assert.AreEqual((double)2.3 <= (int)1, this.operators.LessEqualObject((double)2.3, (int)1));
            Assert.AreEqual((double)2.3 <= (int)2, this.operators.LessEqualObject((double)2.3, (int)2));
        }        

        [TestMethod]
        public void LessEqualDoubleLong()
        {
            Assert.AreEqual((double)1.2 <= (long)1, this.operators.LessEqualObject((double)1.2, (long)1));
            Assert.AreEqual((double)1.2 <= (long)2, this.operators.LessEqualObject((double)1.2, (long)2));
            Assert.AreEqual((double)2.3 <= (long)1, this.operators.LessEqualObject((double)2.3, (long)1));
            Assert.AreEqual((double)2.3 <= (long)2, this.operators.LessEqualObject((double)2.3, (long)2));
        }        

        [TestMethod]
        public void LessEqualDoubleFloat()
        {
            Assert.AreEqual((double)1.2 <= (float)1.2, this.operators.LessEqualObject((double)1.2, (float)1.2));
            Assert.AreEqual((double)1.2 <= (float)2.3, this.operators.LessEqualObject((double)1.2, (float)2.3));
            Assert.AreEqual((double)2.3 <= (float)1.2, this.operators.LessEqualObject((double)2.3, (float)1.2));
            Assert.AreEqual((double)2.3 <= (float)2.3, this.operators.LessEqualObject((double)2.3, (float)2.3));
        }        

        [TestMethod]
        public void LessEqualDoubleDouble()
        {
            Assert.AreEqual((double)1.2 <= (double)1.2, this.operators.LessEqualObject((double)1.2, (double)1.2));
            Assert.AreEqual((double)1.2 <= (double)2.3, this.operators.LessEqualObject((double)1.2, (double)2.3));
            Assert.AreEqual((double)2.3 <= (double)1.2, this.operators.LessEqualObject((double)2.3, (double)1.2));
            Assert.AreEqual((double)2.3 <= (double)2.3, this.operators.LessEqualObject((double)2.3, (double)2.3));
        }        
    }
}
