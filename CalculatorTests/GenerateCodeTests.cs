using CalculatorLibrary;
using System.Diagnostics;

namespace CalculatorTests
{
    public class GenerateCodeTests
    {
        [Theory]
        [InlineData(5)]
        public void GenerateCode_GenerateOneCode_ShouldReturnCodeWithLength5(int length)
        {
            //Arange
            //Act
            string randomCode = GenerateOneTimeCode.GenerateCode(length);
            int lengthRandomCode = randomCode.Length;
            //Assert
            Assert.Equal(lengthRandomCode, length);
        }

        [Theory]
        [InlineData(-1)]
        public void GenerateCode_NegativeLength_ShouldThrowError(int length)
        {
            //Arange
            //Act
            var exception = Assert.Throws<ArgumentException>(() => GenerateOneTimeCode.GenerateCode(length));
            //Assert
            Assert.Equal("Negatives not allowed", exception.Message);
        }
    }
}
