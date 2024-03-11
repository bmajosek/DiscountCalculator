using System;
using System.Collections.Generic;
namespace CalculatorLibrary
{
    public static class Calculator
    {
        public static decimal CalculateDiscount(decimal price, string discountCode)
        {
            if (price < 0)
            {
                throw new ArgumentException("Negatives not allowed");
            }
            if (GlobalVariables.DiscountValues.TryGetValue(discountCode, out decimal discount))
            {
                price = price - price * discount;
            }
            else if (GenerateOneTimeCode.OneTimeDiscount.Contains(discountCode))
            {
                GenerateOneTimeCode.OneTimeDiscount.Remove(discountCode);
                price /= 2;
            }
            else
            {
                throw new ArgumentException("Invalid discount code");
            }
            return price;
        }
    }
}
