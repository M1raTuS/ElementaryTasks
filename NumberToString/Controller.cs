namespace NumberToString
{
    class Controller
    {
        readonly View view = new View();

        public void Start()
        {
            do
            { 
                Run(view.EnterNumber()); 
            }
            while (view.Resume());
        }

        public void Run(string arg)
        {
            Numbers numbers;

            try
            {
                numbers = new Numbers(arg);

                if (numbers.IsZero)
                {
                    view.Zero();
                }
                else
                {
                    System.Console.WriteLine();
                    foreach (Number number in numbers)
                    {
                        if (number.ToString().Length > 0)
                        {
                            view.Print(number.ToString());
                        }
                    }
                }
            }
            catch
            {
                view.IncorrectValue();
            }
        }
    }
}
