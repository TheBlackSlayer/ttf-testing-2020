using System;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string str)
        {
            if (str is null)
            {
                return 0;
            }
            try
            {
                return Convert.ToInt32(str);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
