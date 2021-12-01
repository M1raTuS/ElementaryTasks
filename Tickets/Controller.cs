using System;

namespace Tickets
{
    public class Controller
    {
        public bool resume { get; set; } = false;

        public void Run()
        {
            Tickets tickets = new Tickets();

            do
            {
                int min;
                int max;

                View.FirstTicket(out min);
                View.SecondTicket(out max);
                
                if (!Checker.MinMaxValidator(min, max))
                {
                    View.IncorectValue();
                }
                else
                {
                    int firstTickets = tickets.Count(min, max, false);
                    int secondTickets = tickets.Count(min, max, true);
                    int resultWinner = tickets.Compare(firstTickets, secondTickets);

                    View.Firstway(firstTickets);
                    View.SecondWay(secondTickets);
                    View.Winner(resultWinner);
                }

                resume = View.Resume();
            }
            while (resume);
        }
    }
}
