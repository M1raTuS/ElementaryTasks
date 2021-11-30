﻿using System;

namespace Envelopes
{
    public class Controller
    {
        public float height { get; set; }
        public float width { get; set; }

        Checker checker = new Checker();
        Envelope envelope1;
        Envelope envelope2;

        public void Run(View view)
        {
            do
            {
                try
                {
                    Console.WriteLine("Введите значения для первого конверта");

                    height = view.EnterSides("Введите a: ");
                    width = view.EnterSides("Введите b: ");

                    envelope1 = checker.envelopeModel(height, width);

                    Console.WriteLine("\nВведите значения для Второго конверта");

                    height = view.EnterSides("Введите c: ");
                    width = view.EnterSides("Введите d: ");

                    envelope2 = checker.envelopeModel(height, width);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
            while (view.PrintResult(checker.PutEnvelope(envelope1, envelope2)));
        }
    }
}
