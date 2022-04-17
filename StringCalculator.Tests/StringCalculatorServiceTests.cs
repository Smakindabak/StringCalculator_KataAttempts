using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Core.Tests
{
    [TestClass()]
    public class StringCalculatorServiceTests
    {
        private StringCalculatorService _sut = new StringCalculatorService();
        [TestMethod()]
        public void Add_ShouldReturnZeroIfStringIsNull()
        {
            int expected = 0;
            int actual = _sut.Add(null);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Add_ShouldReturnNumberOfStringInput()
        {
            int expected = 2;
            int actual = _sut.Add("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Add_ShouldReturnSumOfStringInputs()
        {
            int expected = 3;
            int actual = _sut.Add("1,2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Add_ShouldReturnSumOfUnknownNumberOfStringInputs()
        {
            int expected = 13;
            int actual = _sut.Add("1,2,7,3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Add_ShouldAllowNewLineForStringInputs()
        {
            int expected = 6;
            int actual = _sut.Add("1\n2,3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Add_ShouldAllowChangingDelimitersStringInputs()
        {
            int expected = 3;
            int actual = _sut.Add("//;\n1;2");

            Assert.AreEqual(expected, actual);
        }
    }
}