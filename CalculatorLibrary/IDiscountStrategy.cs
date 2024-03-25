﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public interface IDiscountStrategy
    {
        decimal CalculateDiscount(decimal price);
    }
}
