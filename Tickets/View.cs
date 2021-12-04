using System;
using System.Collections.Generic;

namespace Tickets
{
    public class View
    {
        public bool Resume()
        {
            Console.WriteLine("\nВвести новые билеты (y/yes)?");

            switch (Console.ReadLine().ToLower())
            {
                case "y":
                case "yes":
                    Console.WriteLine("");
                    return true;
                default:
                    return false;
            }
        }

        public void IncorrectValue()
        {
            Console.WriteLine("\nНомер билета должен быть целым числом в диапазоне от 1 до 999999");
        }

        public void Firstway(int firstAmount)
        {
            Console.WriteLine($"\nПростой способ обнаружил {firstAmount} счастливых билетов.");
        }

        public void SecondWay(int secondAmount)
        {
            Console.WriteLine($"Сложный способ обнаружил {secondAmount} счастливых билетов.");
        }

        public void Winner(int winner)
        {
            if (winner != 2)
            {
                List<string> ways = new List<string>() { "Первый", "Второй" };
                Console.WriteLine($"{ways[winner]} способ победил!");
            }
            else
            {
                Console.WriteLine("Способы равны.");
            }
        }

        public int MinimalTicketValue()
        {
            int value;

            Console.Write("Введите начало диапазона: ");

            int.TryParse(Console.ReadLine(), out value);

            return value;
        }

        public int MaximalTicketValue()
        {
            int value;

            Console.Write("Введите конец диапазона: ");

            int.TryParse(Console.ReadLine(), out value);

            return value;
        }
    }
}
