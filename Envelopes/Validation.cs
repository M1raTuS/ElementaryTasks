using System;

namespace Envelopes
{
    public class Validation
    {
        public bool ValueLimitValidate(out float currentSize)
        {
            const float minValueLimit = 0;
            const float maxValueLimit = float.MaxValue;

            bool isCheck = false;

            float.TryParse(Console.ReadLine(), out currentSize);

            if (currentSize > minValueLimit && currentSize <= maxValueLimit)
            {
                isCheck = true;
            }

            return isCheck;
        }
    }
}
