using System;
using System.Globalization;

namespace InterviewQuestions.Challenges.Challenge7
{
    /*
     * Starting with a 1-indexed array of zeros and a list of operations,
     * for each operation add a value to each of the array element between two given indices, inclusive.
     * 
     * Once all operations have been performed, return the maximum value in the array.
     */
    public static class Challenge7
    {
        public static long CalculateMaximumValue(int n, int[][] queries)
        {
            // [0,100,100,0,0,0]
            int[] zeroArray = new int[n];
            
            for (int i = 0; i < queries.Length; i++)
            {
                int startPos = queries[i][0] - 1;
                int endPos = queries[i][1] - 1;
                int incr = queries[i][2];

                zeroArray[startPos] += incr;
                if (endPos + 1 < queries.Length)
                    zeroArray[endPos + 1] -= incr;

//                for (int j = 0; j < endPos - startPos; j++)
//                {
//                    zeroArray[startPos + j] += incr;
//                    if (zeroArray[startPos + j] > maxValue)
//                    {
//                        maxValue = zeroArray[startPos + j];
//                    }
//                }
            }

            int currentNumber = 0;
            int highestNumber = Int32.MinValue;
            
            for (int i = 0; i < zeroArray.Length; i++)
            {
                currentNumber += zeroArray[i];
                if (currentNumber > highestNumber)
                {
                    highestNumber = currentNumber;
                }
            }
            
            return highestNumber;
        }
    }
}