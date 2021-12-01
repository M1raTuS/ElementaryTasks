using System;

namespace Envelopes
{
    public class View
    {
        Checker check = new Checker();

        public float EnterSides(string inputString)
        {
            const float minValue = 1;
            const float maxValue = float.MaxValue;
            float currentSize;

            Console.Write(inputString);
            
            while (!check.CheckValueLimit(out currentSize))
            {
                Console.WriteLine($"\nНеобходимо ввести число в диапазоне {minValue} - {maxValue}");
                Console.Write(inputString);
            }

            return currentSize;
        }

        public bool PrintResult(int result)
        {
            switch (result)
            {
                case 1:
                    Console.WriteLine("\nПервый конверт может быть помещен во второй");
                    break;
                case 2:
                    Console.WriteLine("\nВторой конверт может быть помещен в первый");
                    break;
                default:
                    Console.WriteLine("\nНи один конверт не может быть помещен в другой");
                    break;
            }

            Console.WriteLine("\nПроверить другие конверты (y/yes)?");

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
    }
}
