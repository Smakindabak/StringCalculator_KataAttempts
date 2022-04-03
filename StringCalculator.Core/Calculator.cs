using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Core
{
    public class Calculator
    {
        public int Add(string numberText)
        {
            int result = default;

            var numbers = numberText.Split(',');

            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int value))
                {
                    result += value;
                } 
            }

            return result;
        }

       
    }
}
