﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public interface IDiscountFactory
    {
        IDiscountStrategy Create(string DiscountCode);
    }
}
