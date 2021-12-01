namespace Envelopes
{
    public class Envelope
    {
        public float width { get; set; }
        public float height { get; set; }

        public Envelope(float height, float width)
        {
            this.height = height;
            this.width = width;
        }

        public int PutEnvelope(Envelope anotherEnvelope)
        {
            int envelopeResult = 0;

            if (width < anotherEnvelope.width & height < anotherEnvelope.height)
            {
                envelopeResult = 1;
            }
            else if (width < anotherEnvelope.height & height < anotherEnvelope.width)
            {
                envelopeResult = 1;
            }
            else if (anotherEnvelope.width < width & anotherEnvelope.height < height)
            {
                envelopeResult = 2;
            }
            else if (anotherEnvelope.width < height & anotherEnvelope.height < width)
            {
                envelopeResult = 2;
            }

            return envelopeResult;
        }
    }
}
