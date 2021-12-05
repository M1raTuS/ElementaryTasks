namespace Tickets
{
    public class Controller
    {
        public bool IsResume { get; set; } = false;

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
                    int firstTickets = tickets.TicketsCount(min, max, EStates.SimpleMethod);
                    int secondTickets = tickets.TicketsCount(min, max, EStates.DifficultMethod);
                    int resultWinner = tickets.CompareResult(firstTickets, secondTickets);

                    view.Firstway(firstTickets);
                    view.SecondWay(secondTickets);
                    view.Winner(resultWinner);
                }

                IsResume = view.Resume();
            }
            while (IsResume);
        }
    }
}
