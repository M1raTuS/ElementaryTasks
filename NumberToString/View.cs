using System;

namespace NumberToString
{
    class View
    {
        public void IncorrectValue()
        {
            Console.WriteLine("Введите целое число от 0 до 999999999999999999999 без разделителей");
        }

        public string EnterNumber()
        {
            Console.Write("Введите число: ");
            return (Console.ReadLine());
        }

        public void Print(string value)
        {
            Console.WriteLine(value);
        }

        public bool Resume()
        {
            Console.WriteLine("\nВвести новое число (y/yes)?");

            switch (Console.ReadLine().ToLower())
            {
                case "y":
                case "yes":
                    Console.WriteLine();
                    return true;
                default:
                    return false;
            }
        }

        public void Zero()
        {
            Console.WriteLine("ноль");
        }

    }
}
