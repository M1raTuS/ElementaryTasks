namespace Envelopes
{
    public class Envelope
    {
        private float Height { get; set; }
        private float Width { get; set; }

        public Envelope(float height, float width)
        {
            Height = height;
            Width = width;
        }

        public int PutEnvelope(Envelope anotherEnvelope)
        {
            int envelopeResult = 0;

            if ((Width < anotherEnvelope.Width && Height < anotherEnvelope.Height)
               || (Width < anotherEnvelope.Height && Height < anotherEnvelope.Width))
            {
                envelopeResult = 1;
            }
            else if ((anotherEnvelope.Width < Width && anotherEnvelope.Height < Height)
                    || (anotherEnvelope.Width < Height && anotherEnvelope.Height < Width))
            {
                envelopeResult = 2;
            }

            return envelopeResult;
        }
    }
}
