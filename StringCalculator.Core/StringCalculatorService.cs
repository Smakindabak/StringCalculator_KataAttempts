using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Core
{
    public class StringCalculatorService
    {
        public int Add(string numbers)
        {
            int result = 0;

            if (numbers == null)
            {
                return result;
            }

            numbers = ReplaceNewLineWithComma(numbers);

            foreach (var part in PartsOfCSV(numbers))
            {
                result += int.Parse(part);
            }
            
            return result;
        }

        private string ReplaceNewLineWithComma(string numbers)
        {
            return numbers.Replace("\n", ",");
        }

        private string[] PartsOfCSV(string numbers)
        {
            string[] result;
            return numbers.Split(',');
        }

    }
}
