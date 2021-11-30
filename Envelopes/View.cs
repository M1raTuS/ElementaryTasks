using System;

namespace Envelopes
{
    public class View
    {
        public void Start()
        {
            //Console.WriteLine("Hello World");
        }

        public float EnterSides(string inputString)
        {
            float currentSize;

            Console.Write(inputString);

            while (!float.TryParse(Console.ReadLine(), out currentSize))
            {
                Console.WriteLine("\nНеобходимо ввести число в диапазоне 1 - 3.4e38f");
                Console.Write(inputString);
            }

            return currentSize;
        }

        public EnvelopeModel envelopeModel()
        {
            float a1Size = 1;
            float b1Size = 1;

            return new EnvelopeModel
            {
                height = a1Size,
                width = b1Size
            };

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
                    Console.WriteLine("\n2Ни один конверт не может быть помещен в другой");
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
