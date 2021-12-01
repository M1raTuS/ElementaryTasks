using System;
using System.Collections.Generic;

namespace Tickets
{
    public class View
    {
        public static bool Resume()
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

        public static void IncorectValue()
        {
            Console.WriteLine("\nНомер билета должен быть в диапазоне от 1 до 999999: ");
        }

        public static void Firstway(int firstAmount)
        {
            Console.WriteLine($"\nПростой способ обнаружил {firstAmount} счастливых билетов.");
        }

        public static void SecondWay(int secondAmount)
        {
            Console.WriteLine($"Сложный способ обнаружил {secondAmount} счастливых билетов.");
        }

        public static void Winner(int winner)
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

        public static void FirstTicket(out int value)
        {
            Console.Write("Введите начало диапазона: ");
            int.TryParse(Console.ReadLine(), out value);
        }

        public static void SecondTicket(out int value)
        {
            Console.Write("Введите конец диапазона: ");
            int.TryParse(Console.ReadLine(), out value);
        }
    }
}
