using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace NumberToString
{
    public class Numbers
    {
        public bool IsZero { get; } = true;
        private Stack<Number> NumberStackList { get; } = new Stack<Number>();

        public IEnumerator GetEnumerator()
        {
            foreach (Number number in NumberStackList)
            {
                yield return number;
            }
        }

        public Numbers(string originNumber)
        {
            const int ranksInClass = 3;

            while (originNumber.Length % 3 > 0)
            {
                originNumber = "0" + originNumber;
            }

            for (int i = originNumber.Length - 1, j = 0; i >= 0; i -= ranksInClass, j++)
            {
                StringBuilder tempString = new StringBuilder();
                tempString.Append(originNumber.Substring(i - 2));

                NumberStackList.Push(new Number(j, tempString.ToString()));

                if (NumberStackList.Peek().ToString().Length > 0)
                {
                    IsZero = false;
                }
            }
        }
    }
}
