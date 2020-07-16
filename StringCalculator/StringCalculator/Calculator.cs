using System;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string str)
        {
            if (str == "")
            {
                return 0;
            }
            if (str.Contains(","))
            {
                string[] numbers = str.Split(",");
                return Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]);
            }
            return Convert.ToInt32(str);
        }
    }
}
