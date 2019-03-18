using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge8
{
    [TestFixture]
    public class Challenge8Tests
    {
        [Test]
        public void Test1()
        {
            const int nodeCount = 4;
            const int edgeCount = 2;
            const int startingNode = 1;

            var connectingNodes = new int[2][];
            connectingNodes[0] = new[] {1, 2};
            connectingNodes[1] = new[] {1, 3};

            var distances = Challenge8.GetDistances(nodeCount, edgeCount, startingNode, connectingNodes);
            Assert.AreEqual(6, distances[0]);
            Assert.AreEqual(6, distances[1]);
            Assert.AreEqual(-1, distances[2]);
        }
    }
}