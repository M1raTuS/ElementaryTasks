namespace Envelopes
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            View view = new View();
            controller.Run(view);
        }
    }
}
