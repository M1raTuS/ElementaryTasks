namespace Tickets
{
    public class Validation
    {
        public static bool MinMaxValidator(int min, int max)
        {
            const int zero = 0;
            bool isValid = false;

            if (min > zero && max > zero && min < max)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
