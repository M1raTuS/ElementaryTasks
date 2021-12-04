using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Envelopes.Tests
{
    [TestClass()]
    public class EnvelopeTests
    {
        [TestMethod()]
        public void EnvelopeTest()
        {
            // arrange

            var firstEnvelope = new Envelope(10.235f, 10.757f);
            var secondEnvelope = new Envelope(11, 11);
            var expectedResult = 1;

            // act

            var result = firstEnvelope.PutEnvelope(secondEnvelope);

            // assert

            Assert.AreEqual(expectedResult, result);
        }
    }
}