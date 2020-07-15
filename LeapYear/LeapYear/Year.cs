using System;

namespace LeapYear
{
    public class Year
    {
        public static bool Calculate(int anno)
        {
            if (anno == 0)
            {
                throw new InvalidOperationException();
            }

            if (anno < 0)
            {
                return false;
            }

            if (anno < 1581)
            {
                if (anno % 100 == 0)
                {
                    return true;
                }
            }

            if (anno % 400 == 0)
            {
                return true;
            }
            if (anno % 100 == 0)
            {
                return false;
            }
            if (anno % 4 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
