using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class DiscountCalculatorFactory : IDiscountFactory
    {
        public IDiscountStrategy Create(string discountCode)
        {
            if (GlobalVariables.DiscountValues.TryGetValue(discountCode, out decimal discount))
            {
                return new PercentageDiscountStrategy(discount);
            }
            else if (GenerateOneTimeCode.OneTimeDiscount.Contains(discountCode))
            {
                GenerateOneTimeCode.OneTimeDiscount.Remove(discountCode);
                return new PercentageDiscountStrategy(0.5M);
            }
            throw new ArgumentException("Invalid discount code");

        }
    }
}
