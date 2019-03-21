using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge9
{
    [TestFixture]
    public class Challenge9Tests
    {
        [Test]
        public void Test1()
        {
            int[] number = new[] {1, 3, 5, 7};

            int[] newNumber = Challenge9.IncrementNumber(number);
            
            // Expected 1358
            Assert.AreEqual(1, newNumber[0]);
            Assert.AreEqual(3, newNumber[1]);
            Assert.AreEqual(5, newNumber[2]);
            Assert.AreEqual(8, newNumber[3]);
        }
        
        [Test]
        public void Test2()
        {
            int[] number = new[] {1, 3, 5, 9};

            int[] newNumber = Challenge9.IncrementNumber(number);
            
            // Expected 1360
            Assert.AreEqual(1, newNumber[0]);
            Assert.AreEqual(3, newNumber[1]);
            Assert.AreEqual(6, newNumber[2]);
            Assert.AreEqual(0, newNumber[3]);
        }       
        
        [Test]
        public void Test3()
        {
            int[] number = new[] {9, 9, 9, 9};

            int[] newNumber = Challenge9.IncrementNumber(number);
            
            // Expected 1358
            Assert.AreEqual(1, newNumber[0]);
            Assert.AreEqual(0, newNumber[1]);
            Assert.AreEqual(0, newNumber[2]);
            Assert.AreEqual(0, newNumber[3]);
            Assert.AreEqual(0, newNumber[4]);
        }
    }
}