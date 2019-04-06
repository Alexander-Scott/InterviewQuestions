using System;

namespace InterviewQuestions.Challenges.Challenge3
{
    public static class Challenge3
    {
        public static int[] FindLargestSubsequence(int[] integers)
        {
            // {10, 3, 7, 9, 0, 15}

            int firstIndexOfRun = 0;
            int runLength = 1;
            int longestRun = 0;
            int firstIndexOfLongestRun = 0;

            for (int i = 1; i < integers.Length; i++)
            {
                if (integers[i] > integers[i - 1])
                {
                    runLength++;

                }
                else
                {
                    if (runLength > longestRun)
                    {
                        longestRun = runLength;
                        firstIndexOfLongestRun = firstIndexOfRun;
                    }
                        
                    runLength = 1;
                    firstIndexOfRun = i;
                }
            }

            if (longestRun == 0)
            {
                longestRun = runLength;
            }
            
            int[] returnIndexes = new int[longestRun];

            for (int i = 0; i < longestRun; i++)
            {
                returnIndexes[i] = firstIndexOfLongestRun + i;
            }

            return returnIndexes;
        }
    }
}