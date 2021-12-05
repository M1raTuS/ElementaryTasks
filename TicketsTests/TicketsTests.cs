using NUnit.Framework;
using Tickets;

namespace TicketsTests
{
    public class Tests
    {
        private Tickets.Tickets tickets;

        [SetUp]
        public void Setup()
        {
            tickets = new Tickets.Tickets();
        }

        [Test]
        public void SimpleTicketsCount()
        {
            // arrange

            int min = 1;
            int max = 999999;
            int expected = 55251;

            // act

            var result = tickets.TicketsCount(min, max, EStates.SimpleMethod);

            // assert 

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DifficultTicketsCount()
        {
            // arrange

            int min = 1;
            int max = 999999;
            int expected = 55251;

            // act

            var result = tickets.TicketsCount(min, max, EStates.DifficultMethod);

            // assert 

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TicketsCompareResult()
        {
            // arrange

            var firstTicket = tickets.TicketsCount(1, 200000, EStates.SimpleMethod);
            var secondTicket = tickets.TicketsCount(1, 200000, EStates.DifficultMethod);
            int expected = 2;

            // act

            var result = tickets.CompareResult(firstTicket, secondTicket);

            // assert 

            Assert.AreEqual(result, expected);
        }
    }
}