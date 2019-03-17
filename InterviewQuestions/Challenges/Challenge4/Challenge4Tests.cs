using System;
using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge4
{
    [TestFixture]
    public class Challenge4Tests
    {
        [Test]
        public void Test1()
        {
            int dividend = 96;
            int divisor = 8;

            int result = Challenge4.DivideNumber(dividend, divisor);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void Test2()
        {
            Random rand = new Random();
            int dividend = rand.Next(10000);
            int divisor = rand.Next(dividend);
            
            int result = Challenge4.DivideNumber(dividend, divisor);
            int expectedResult = dividend / divisor;
            Assert.AreEqual(expectedResult, result);
        }
    }
}