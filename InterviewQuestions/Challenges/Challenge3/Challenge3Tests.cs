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
            Assert.AreEqual(2, indexes[1]);
            Assert.AreEqual(3, indexes[2]);
        }
        
        [Test]
        public void Test2()
        {
            var array = new[] {1, 2, 3, 4, 5, 6};
            var indexes = Challenge3.FindLargestSubsequence(array);
            Assert.AreEqual(0, indexes[0]);
            Assert.AreEqual(1, indexes[1]);
            Assert.AreEqual(2, indexes[2]);
        }
        
        [Test]
        public void Test3()
        {
            var array = new[] {1, 1, 1, 1, 1, 1};
            var indexes = Challenge3.FindLargestSubsequence(array);
            Assert.AreEqual(0, indexes[0]);
        }
    }
}