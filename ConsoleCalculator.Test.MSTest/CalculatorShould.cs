using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator.Test.MSTest
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void ThrownWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            Assert.ThrowsException<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

            //Assert.ThrowsException<CalculationException>(
            //    () => sut.Calculate(1, 1, "+"));

           var ex = Assert.ThrowsException<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

           Assert.AreEqual("+", ex.Operation);
        }
    }
}
