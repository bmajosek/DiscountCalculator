using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public static class GlobalVariables
    {
        public static readonly string SAVE10NOW = "SAVE10NOW";
        public static readonly string DISCOUNT20OFF = "DISCOUNT20OFF";
        public static readonly Dictionary<string, decimal> DiscountValues = new Dictionary<string, decimal>()
        {
            {GlobalVariables.SAVE10NOW, 0.1M },
            {GlobalVariables.DISCOUNT20OFF, 0.2M },
            {string.Empty, 0 },
        };
        public static readonly string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    }
}
