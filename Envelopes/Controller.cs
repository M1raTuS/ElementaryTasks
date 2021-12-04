namespace Envelopes
{
    public class Controller
    {
        public void Run(View view)
        {
            Envelope envelope1;
            Envelope envelope2;

            do
            {
                float height, width;

                view.PrintFirstInfoMessage();

                height = view.SetSides("Введите a: ");
                width = view.SetSides("Введите b: ");

                envelope1 = new Envelope(height, width);

                view.PrintSecondInfoMessage();

                height = view.SetSides("Введите c: ");
                width = view.SetSides("Введите d: ");

                envelope2 = new Envelope(height, width);
            }
            while (view.PrintResult(envelope1.PutEnvelope(envelope2)));
        }
    }
}
