using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator.Core;

namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCalculator_Add
    {
        [TestMethod]
        public void ShouldReturnAnInteger()
        {
            Calculator _sut = new Calculator();

            int expectedType = default;

            var actualType = _sut.Add("");

            Assert.AreEqual(expectedType.GetType(), actualType.GetType());

        }

        [DataRow("",0)]
        [DataRow("1",1)]
        [DataRow("2", 2)]
        [DataRow("1,2",3)]
        [DataRow("1,2,3,4,5", 15)]
        [DataTestMethod]
        public void ShouldReturnValidNumbers(string numberText, int expected)
        {
            Calculator _sut = new Calculator();

            var actual = _sut.Add(numberText);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ShouldAllowLineEscapeAsSeparator()
        {
            Calculator _sut = new Calculator();

            int expected = 6;

            var actual = _sut.Add("1\n2,3");

            Assert.AreEqual(expected, actual);

        }

    }
        
    
}
