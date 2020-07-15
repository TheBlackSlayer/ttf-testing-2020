using System;

namespace LeapYear
{
    public class Year
    {
        public static bool Calculate(int anno)
        {
            if (anno % 4 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
