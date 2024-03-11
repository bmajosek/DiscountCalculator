using CalculatorLibrary;
namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(10)]
        public void CalculateDiscount_EmptyCode_ShouldnReturn10(decimal price)
        {
            //Arange
            var code = string.Empty;
            //Act
            price = Calculator.CalculateDiscount(price, code);
            //Assert
            Assert.Equal(10, price);
        }

        [Theory]
        [InlineData(10)]
        public void CalculateDiscount_SAVE10NOW_ShouldReturn9(decimal price)
        {
            //Arange
            string code = GlobalVariables.SAVE10NOW;
            //Act
            price = Calculator.CalculateDiscount(price, code);
            //Assert
            Assert.Equal(9, price);
        }

        [Theory]
        [InlineData(10)]
        public void CalculateDiscount_DISCOUNT20OFF_ShouldReturn8(decimal price)
        {
            //Arange
            string code = GlobalVariables.DISCOUNT20OFF;
            //Act
            price = Calculator.CalculateDiscount(price, code);
            //Assert
            Assert.Equal(8, price);
        }

        [Theory]
        [InlineData(-10)]
        public void CalculateDiscount_NegativeValue_ShouldThrowError(decimal price)
        {
            //Arange
            string code = GlobalVariables.DISCOUNT20OFF;
            //Act
            var exception = Assert.Throws<ArgumentException>(() => Calculator.CalculateDiscount(price, code));
            //Assert
            Assert.Equal("Negatives not allowed", exception.Message);
        }

        [Theory]
        [InlineData("Wrong_discount", 10)]
        public void CalculateDiscount_WrongDiscountCode_ShouldThrowError(string code, decimal price)
        {
            //Arange
            //Act
            var exception = Assert.Throws<ArgumentException>(() => Calculator.CalculateDiscount(price, code));
            //Assert
            Assert.Equal("Invalid discount code", exception.Message);
        }

        [Theory]
        [InlineData(10)]
        public void CalculateDiscount_OneTimeDiscountCode_ShouldGive5(decimal price)
        {
            //Arange
            string code = GenerateOneTimeCode.GenerateCode(5);
            //Act
            price = Calculator.CalculateDiscount(price, code);
            //Assert
            Assert.Equal(5, price);
        }

        [Theory]
        [InlineData(10)]
        public void CalculateDiscount_UsedOneTimeDiscountCode_ShouldThrowError(decimal price)
        {//Arange
            string code = GenerateOneTimeCode.GenerateCode(5);
            //Act
            price = Calculator.CalculateDiscount(price, code);
            var exception = Assert.Throws<ArgumentException>(() => Calculator.CalculateDiscount(price, code));
            //Assert
            Assert.Equal("Invalid discount code", exception.Message);
        }
    }
}