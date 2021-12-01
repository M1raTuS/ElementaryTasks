using System;

namespace Envelopes
{
    public class Checker
    {
        public bool CheckValueLimit(out float currentSize)
        {
            float minValueLimit = 0;
            float maxValueLimit = float.MaxValue;

            bool isCheck = false;

            float.TryParse(Console.ReadLine(), out currentSize);

            if (currentSize > minValueLimit && currentSize < maxValueLimit)
            {
                isCheck = true;
            }

            return isCheck;
        }
    }
}
