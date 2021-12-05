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

        public bool SimpleCountMethod(int[] digits)
        {
            return (digits[0] + digits[1] + digits[2]) == (digits[3] + digits[4] + digits[5]);
        }

        public bool DifficultCountMethod(int[] digits)
        {
            return (digits[0] + digits[2] + digits[4]) == (digits[1] + digits[3] + digits[5]);
        }

        public int CompareResult(int firstTickets, int secondTickets)
        {
            int value = 2;

            if (firstTickets > secondTickets)
            {
                value = 0;
            }
            else if (firstTickets < secondTickets)
            {
                value = 1;
            }

            return value;
        }

        public delegate bool Ways(int[] digits);

        public int TicketsCount(int minNumber, int maxNumber, EStates checkWay)
        {
            int count = 0;

            Ways way;
            way = SimpleCountMethod;

            if (checkWay != 0)
            {
                way = DifficultCountMethod;
            }

            for (int i = minNumber; i <= maxNumber; i++)
            {
                if (way(GetNumbers(i)))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
