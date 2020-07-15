using System;

namespace LeapYear
{
    public class Year
    {
        public static bool Calculate(int anno)
        {
            if (anno % 400 == 0)
            {
                return true;
            }
            else if (anno % 100 == 0)
            {
                return false;
            }
            else if (anno % 4 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
