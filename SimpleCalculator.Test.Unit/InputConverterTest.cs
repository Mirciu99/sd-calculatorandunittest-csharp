using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SimpleCalculator.Test.Unit
{
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();
        [Fact]
        public void ConvertValidStringInputIntoDouble()
        {
            string inputNumber = "10";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.Equal(10, convertedNumber);

        }
    }
}
