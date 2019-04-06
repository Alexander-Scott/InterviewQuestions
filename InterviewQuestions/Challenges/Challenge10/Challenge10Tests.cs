using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge10
{
    [TestFixture]
    public class Challenge10Tests
    {
        [Test]
        public void AllOnesGame()
        {
            var game = new BowlingGame();
            game.AddNewPlayer("Alex");

            while (game.Bowl(1))
            {
            }

            var endScore = game.GetPlayerScore("Alex");
            Assert.AreEqual(20, endScore);
        }

        [Test]
        public void PerfectGame()
        {
            var game = new BowlingGame();
            game.AddNewPlayer("Alex");

            while (game.Bowl(10))
            {
            }

            var endScore = game.GetPlayerScore("Alex");
            Assert.AreEqual(300, endScore);
        }

        [Test]
        public void SpareGame()
        {
            var game = new BowlingGame();
            game.AddNewPlayer("Alex");

            game.Bowl(5);
            game.Bowl(5);
            game.Bowl(3);
            game.Bowl(0);

            while (game.Bowl(0))
            {
            }

            var endScore = game.GetPlayerScore("Alex");
            Assert.AreEqual(16, endScore);
        }

        [Test]
        public void StrikeGame()
        {
            var game = new BowlingGame();
            game.AddNewPlayer("Alex");

            game.Bowl(10);
            game.Bowl(3);
            game.Bowl(4);

            while (game.Bowl(0))
            {
            }

            var endScore = game.GetPlayerScore("Alex");
            Assert.AreEqual(24, endScore);
        }

        [Test]
        public void ZeroGame()
        {
            var game = new BowlingGame();
            game.AddNewPlayer("Alex");

            while (game.Bowl(0))
            {
            }

            var endScore = game.GetPlayerScore("Alex");
            Assert.AreEqual(0, endScore);
        }
    }
}