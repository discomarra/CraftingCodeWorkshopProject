using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    public class ArrabicToRomanConverter
    {
        Dictionary<int, string> romanDigits;

        public ArrabicToRomanConverter()
        {
            romanDigits = new Dictionary<int, string>
            {
                { 1, "I"},
                { 5, "V"},
                { 10, "X"},
                { 50, "L"},
                { 100, "C"},
                { 500, "D"},
                { 1000, "M"},
            };
        }

        public string Convert(int arrabicNumber)
        {
            string result = string.Empty;

            int baseNumber = arrabicNumber;

            int thousands = baseNumber / 1000;
            baseNumber %= 1000;

            int hundreds = baseNumber / 100;
            baseNumber %= 100;

            int tens = baseNumber / 10;
            baseNumber %= 10;

            int singles = baseNumber;

            if (romanDigits.TryGetValue(arrabicNumber, out result))
            {
                return result;
            }

            

            if (tens > 0)
            {
                if (tens < 4)
                {
                    result = ConvertLessThen4(tens, 10);
                }
                else if (tens > 5 && tens < 9)
                {
                    result = ConvertBetween5And9(tens, 10);
                }
                else
                {
                    result = "I" + romanDigits[tens + 1];
                }
            }

            if (singles > 0)
            {
                if (singles < 4)
                {
                    result += ConvertLessThen4(singles, 1);
                }
                else if (singles > 5 && singles < 9)
                {
                    result += ConvertBetween5And9(singles, 1);
                }
                else
                {
                    result += "I" + romanDigits[singles + 1];
                }
            }
            return result;
        }

        private string ConvertBetween5And9(int arrabicNumber, int basisOf10)
        {
            string result = romanDigits[5 * basisOf10];
            int difference = arrabicNumber - 5;

            result += ConvertLessThen4(difference, basisOf10);

            return result;
        }

        private string ConvertLessThen4(int arrabicNumber, int basisOf10)
        {
            string result = string.Empty; 

            for(int i = 0; i < arrabicNumber; i++)
            {
                result += romanDigits[basisOf10];
            }

            return result;
        }
    }
}
