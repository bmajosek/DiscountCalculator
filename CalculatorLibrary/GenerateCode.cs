using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorLibrary
{
    public static class GenerateOneTimeCode
    {
        public static readonly HashSet<string> OneTimeDiscount = new HashSet<string>();
        private static Random random = new Random();
        public static string GenerateCode(int length)
        {
            if(length < 0)
            {
                throw new ArgumentException("Negatives not allowed");
            }
            var randomChar = new string(Enumerable.Repeat(GlobalVariables.Chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            OneTimeDiscount.Add(randomChar);
            return randomChar;
        }
    }
}
