using System;

namespace InterviewQuestions.Challenges.Challenge4
{
    public static class Challenge4
    {
        /*
         * ### Question 4
                Divide two integers without using multiplication, division or the mod operator.
         */
        public static int DivideNumber(int dividend, int divisor)
        {
            int num = dividend; // 96
            int div = divisor; // 8

            int result = 0;
            while (num >= div)
            {
                int shifts = 0;
                int shiftedDiv = div;
                while (num >= shiftedDiv)
                {
                    shiftedDiv = shiftedDiv << 1;
                    shifts++;
                }

                shifts--;
                num -= div << shifts;
                result += 1 << shifts;
            }

            return result;
        }
    }
}