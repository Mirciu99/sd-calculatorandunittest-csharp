using System;
using Xunit;

namespace SimpleCalculator.Test.Unit
{
    public class CalculatorEngineTest
    {
        //first step: setting up your dat for your unit tests
        //second step: processing that data through the method that you want to test
        //third step: comparing the result that you got from the processing against your assumption

        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();
        [Fact]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 5;
            int number2 = 10;
            double result = _calculatorEngine.Calculate("add", number1, number2);
            Assert.Equal(15, result);

        }
        [Fact]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 5;
            int number2 = 10;
            double result = _calculatorEngine.Calculate("+", number1, number2);
            Assert.Equal(15, result);

        }
    }
}
