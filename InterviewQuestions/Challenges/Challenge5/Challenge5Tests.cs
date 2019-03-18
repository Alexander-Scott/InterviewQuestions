using System;
using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge5
{
    [TestFixture]
    public class Challenge5Tests
    {
        [Test]
        public void Test1()
        {
            int maxCarryCapacity = 2;
            
            int[] bins = new int[21];
            for (int i = 0; i < bins.Length; i++)
            {
                bins[i] = i;
            }

            int numberOfTrips = Challenge5.NumberOfTimes(bins, maxCarryCapacity);
            Assert.AreEqual(11, numberOfTrips);
        }
    }
}