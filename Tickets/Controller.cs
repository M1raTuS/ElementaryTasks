namespace Tickets
{
    public class Controller
    {
        public bool resume { get; set; } = false;

        public void Run()
        {
            Tickets tickets = new Tickets();
            View view = new View();

            do
            {
                int min, max;

                min = view.MinimalTicketValue();
                max = view.MaximalTicketValue();

                if (!Validation.MinMaxValidator(min, max))
                {
                    view.IncorrectValue();
                }
                else
                {
                    int firstTickets = tickets.TicketsCount(min, max, false);
                    int secondTickets = tickets.TicketsCount(min, max, true);
                    int resultWinner = tickets.CompareResult(firstTickets, secondTickets);

                    view.Firstway(firstTickets);
                    view.SecondWay(secondTickets);
                    view.Winner(resultWinner);
                }

                resume = view.Resume();
            }
            while (resume);
        }
    }
}
