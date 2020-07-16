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
                int sum = 0;
                foreach (string number in numbers)
                {
                    sum += Convert.ToInt32(number);
                }
                return sum;
            }
            return Convert.ToInt32(str);
        }
    }
}
