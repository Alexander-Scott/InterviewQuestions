using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge6
{
    [TestFixture]
    public class Challenge6Tests
    {
        [Test]
        public void Test1()
        {
            int[] numbers = new[] {8, 16, 11, 4, 14, 6, 7, 1, 12, 10, 3, 9, 18, 5, 15, 2, 17, 13, 0, 19};
            int targetSum = 29;

            int[] indexes = Challenge6.GetIndexes(numbers, targetSum);
            Assert.AreEqual(2, indexes[0]);
            Assert.AreEqual(12, indexes[1]);
        }
    }
}