using System;
using System.Collections.Generic;

namespace InterviewQuestions.Challenges.Challenge6
{
    public static class Challenge6
    {
        /*
         * Given an array of unique integers, return the smallest sum of
         * two indexes who's values add up to a target number.
         * 8, 16, 11, 4, 14, 6, 7, 1, 12, 10, 3, 9, 18, 5, 15, 2, 17, 13, 0, 19
         */
        public static int[] GetIndexes(int[] array, int targetSum)
        {
            int smallestSum = Int32.MaxValue;
            int[] smallestIndexes = null;
            
            // <value, index>
            Dictionary<int, int> values = new Dictionary<int, int>();
            
            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                int targetNumber = targetSum - currentNumber;

                // Value already exists
                if (values.ContainsKey(targetNumber))
                {
                    int indexSum = i + values[targetNumber];
                    if (indexSum < smallestSum)
                    {
                        smallestSum = indexSum;
                        smallestIndexes = new[] {values[targetNumber], i};
                    }
                    continue;
                }

                values.Add(array[i], i);
            }
            return smallestIndexes;
        }
    }
}