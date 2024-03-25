using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class PercentageDiscountStrategy: IDiscountStrategy
    {
        public decimal percentage;

        public PercentageDiscountStrategy(decimal percentage)
        {
            this.percentage = percentage;
        }

        public decimal CalculateDiscount(decimal price) => price * percentage; 
    }
}
