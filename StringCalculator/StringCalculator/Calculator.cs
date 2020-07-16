using System;
using System.Collections.Generic;
using System.Linq;

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

            List<int> numbers = new List<int>();

            if (str.Contains("//"))
            {
                string[] separatoreENumeri = str.Substring(2).Split("\n");
                separatoreENumeri[1].Split(separatoreENumeri[0]).ToList().ForEach(x => numbers.Add(Convert.ToInt32(x)));
            }
            else
            {
                str.Split(new string[] { ",", "\n" }, StringSplitOptions.None).ToList().ForEach(x => numbers.Add(Convert.ToInt32(x)));
            }

            return numbers.Sum();
        }
    }
}
