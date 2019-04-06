using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.PrimeNumberFactorial
{
    public static class PrimeNumberFactorial
    {
        private static readonly int[] primeNumbers = new[] {2, 3, 5, 7, 11, 13, 17};

        public static string[] GetPrimeNumberFactorial(int number)
        {
            var returnStrings = new List<string>();
            var divisionCount = new Dictionary<int,int>();

            for (int i = 0; i < primeNumbers.Length; ++i)
            {
                if (primeNumbers[i] > number)
                {
                    continue;
                }

                if (number % primeNumbers[i] > 0)
                {
                    continue;
                }
                
                StringBuilder builder = new StringBuilder();
                builder.Append(primeNumbers[i]);
                builder.Append("x");
                builder.Append(number / primeNumbers[i]);

                int numOfDivisions = 0;
                int total
                
                returnStrings.Add(builder.ToString());
            }
            
            return returnStrings.ToArray();
        }

        public static int[] FetchPrimeNumbers(int number)
        {
            List<int> primeNumbers = new List<int>();
            
            // Loop over all prime numbers less than/equal to target number
            for (int prime = 2; prime <= number; ++prime)
            {
                bool primeNumber = true;
                
                // Loop over potential divisiors less than prime number to check if prime. If not prime, break out early.
                for (int divisor = 2; divisor < prime; ++divisor)
                {
                    if (prime % divisor > 0)
                    {
                        primeNumber = false;
                        break;
                    }
                }

                if (primeNumber)
                {
                    primeNumbers.Add(prime);
                }
            }

            return primeNumbers.ToArray();
        }
    }
}