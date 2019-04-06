using System;

namespace InterviewQuestions.Challenges.Challenge9
{
    public static class Challenge9
    {
        // {1, 3, 5, 7};
        public static int[] IncrementNumber(int[] number)
        {
            // Increment last digit
            int currentIndex = number.Length - 1;
            number[currentIndex]++;
            
            while (number[currentIndex] == 10 && currentIndex > 0)
            {
                // Set current digit to 0
                number[currentIndex] = 0;
                // Decrement current index and increment previous digit
                number[--currentIndex]++;
            }

            if (number[currentIndex] == 10)
            {
                number = new int[number.Length + 1];
                number[0] = 1;
            }

            return number;
        }
    }
}