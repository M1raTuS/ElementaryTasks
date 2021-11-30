namespace Envelopes
{
    public class Checker
    {
        public int PutEnvelope(Envelope envelope1, Envelope envelope2)
        {
            int result = 0;

            if (envelope1.width < envelope2.width & envelope1.height < envelope2.height)
            {
                result = 1;
            }
            else if (envelope1.width < envelope2.height & envelope1.height < envelope2.width)
            {
                result = 1;
            }
            else if (envelope2.width < envelope1.width & envelope2.height < envelope1.height)
            {
                result = 2;
            }
            else if (envelope2.width < envelope1.height & envelope2.height < envelope1.width)
            {
                result = 2;
            }

            return result;
        }

        public Envelope envelopeModel(float height, float width)
        {
            return new Envelope
            {
                height = height,
                width = width
            };
        }
    }
}
