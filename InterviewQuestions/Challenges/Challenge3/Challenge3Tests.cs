using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge3
{
    [TestFixture]
    public class Challenge3Tests
    {
        [Test]
        public void Test1()
        {
            var array = new[] {10, 3, 7, 9, 0, 15};
            var indexes = Challenge3.FindLargestSubsequence(array);
            Assert.AreEqual(1, indexes[0]);
            Assert.AreEqual(3, indexes[1]);
        }
    }
}