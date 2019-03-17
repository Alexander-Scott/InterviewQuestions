using System;

namespace InterviewQuestions.Challenges.Challenge4
{
    public static class Challenge4
    {
        public static int DivideNumber(int dividend, int divisor)
        {
            // handle special cases
            if (divisor == 0)
                return Int32.MaxValue;
            ;
            if (divisor == -1 && dividend == Int32.MinValue)
                return Int32.MaxValue;
            ;

            // get positive values
            long pDividend = Math.Abs((long) dividend);
            long pDivisor = Math.Abs((long) divisor);

            int result = 0;
            while (pDividend >= pDivisor)
            {
                // calculate number of left shifts
                int numShift = 0;
                while (pDividend >= (pDivisor << numShift))
                {
                    numShift++;
                }

                // dividend minus the largest shifted divisor
                result += 1 << (numShift - 1);
                pDividend -= (pDivisor << (numShift - 1));
            }

            if ((dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0))
            {
                return result;
            }
            else
            {
                return -result;
            }
        }
    }
}