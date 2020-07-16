using System;
using System.Collections.Generic;

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
            if (str.Contains(",") || str.Contains("\n"))
            {
                List<string> numbers = new List<string>();
                string[] subStrings = str.Split(",");

                foreach (string subString in subStrings)
                {
                    if (subString.Contains("\n"))
                    {
                        string[] bnSubStrings = subString.Split("\n");

                        foreach (string bnSubString in bnSubStrings)
                        {
                            numbers.Add(bnSubString);
                        }
                    }
                    else
                    {
                        numbers.Add(subString);
                    }
                }

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
