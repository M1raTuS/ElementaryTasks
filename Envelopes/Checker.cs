namespace Envelopes
{
    public class Checker
    {
        public float width { get; set; }
        public float height { get; set; }

        public int PutEnvelope(EnvelopeModel envelope1, EnvelopeModel envelope2)
        {
            if (envelope1.width < envelope2.width & envelope1.height < envelope2.height)
                return 1;
            else if (envelope2.width < envelope1.width & envelope2.height < envelope1.height)
                return 2;
            return 0;
        }

        public EnvelopeModel envelopeModel(float height, float width)
        {
            return new EnvelopeModel
            {
                height = height,
                width = width
            };
        }
    }
}
