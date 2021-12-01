namespace Tickets
{
    public class Tickets
    {
        public int[] GetNumbers(int number)
        {
            int[] digits = new int[6];
            digits[0] = number / 100000;
            digits[1] = (number / 10000) % 10;
            digits[2] = (number / 1000) % 10;
            digits[3] = (number / 100) % 10;
            digits[4] = (number / 10) % 10;
            digits[5] = number % 10;

            return digits;
        }

        public bool FirstWay(int[] digits)
        {
            return (digits[0] + digits[1] + digits[2]) == (digits[3] + digits[4] + digits[5]);
        }

        public bool SecondWay(int[] digits)
        {
            return (digits[0] + digits[2] + digits[4]) == (digits[1] + digits[3] + digits[5]);
        }

        public int Compare(int firstTickets, int secondTickets)
        {
            int value;

            if (firstTickets > secondTickets)
            {
                value = 0;
            }
            else if (firstTickets < secondTickets)
            {
                value = 1;
            }
            else
            {
                value = 2;
            }

            return value;
        }

        public int Count(int minNumber, int maxNumber, bool flag)
        {
            int count = 0;

            for (int i = minNumber; i <= maxNumber; i++)
            {
                if (!flag)
                {
                    if (FirstWay(GetNumbers(i)))
                    {
                        count++;
                    }
                }
                else
                {
                    if (SecondWay(GetNumbers(i)))
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
