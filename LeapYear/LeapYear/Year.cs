using System;

namespace LeapYear
{
    public class Year
    {
        public static bool Calculate(int anno)
        {
            if (anno % 4 == 0)
            {
                if (anno % 100 == 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
