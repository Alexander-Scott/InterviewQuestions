using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge7
{
    [TestFixture]
    public class Challenge7Tests
    {
        [Test]
        public void Test1()
        {
            var queries = new int[3][];
            queries[0] = new int[3];
            queries[0][0] = 1;
            queries[0][1] = 2;
            queries[0][2] = 100;
            
            queries[1] = new int[3];
            queries[1][0] = 2;
            queries[1][1] = 5;
            queries[1][2] = 100;
            
            queries[2] = new int[3];
            queries[2][0] = 3;
            queries[2][1] = 4;
            queries[2][2] = 100;

            var value = Challenge7.CalculateMaximumValue(5, queries);
            Assert.AreEqual(200, value);
        }
    }
}