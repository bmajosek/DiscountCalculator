using System;
using System.Collections.Generic;
namespace CalculatorLibrary
{
    public class Calculator
    {
        public readonly IDiscountFactory _discountFactory;

        public Calculator(IDiscountFactory discountFactory)
        {
            _discountFactory = discountFactory;
        }

        public decimal CalculateDiscount(decimal price, string discountCode)
        {
            if (price < 0)
            {
                throw new ArgumentException("Negatives not allowed");
            }
            IDiscountStrategy strategy = _discountFactory.Create(discountCode);
            return Math.Min(price - strategy.CalculateDiscount(price), 0);
        }
    }
}
