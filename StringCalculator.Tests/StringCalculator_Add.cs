using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator.Core;

namespace StringCalculator.Tests
{
    [TestClass]
    class StringCalculator_Add
    {
        [TestMethod]
        public void ShouldReturnAnInteger()
        {
            Calculator _sut = new Calculator();

            int expectedType = default;

            var actualType = _sut.Add();

            Assert.AreEqual(expectedType.GetType(), actualType.GetType());

        }
    }
        
    
}
