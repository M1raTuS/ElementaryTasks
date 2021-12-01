using System;

namespace Tickets
{
    public class Checker
    {
        public static bool MinMaxValidator(int min, int max)
        {
            bool isValid = false;

            if (min > 0 && max > 0 && min < max)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
