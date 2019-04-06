using NUnit.Framework;

namespace InterviewQuestions.PrimeNumberFactorial
{
    [TestFixture]
    public class PrimeNumberTests
    {
        [Test]
        public void Test1()
        {
            int testNumber = 0;
            var result = PrimeNumberFactorial.GetPrimeNumberFactorial(testNumber);
            
            Assert.AreEqual(0, result.Length);
        }

        [Test]
        public void Test2()
        {
            int testNumber = 1;
            var result = PrimeNumberFactorial.GetPrimeNumberFactorial(testNumber);
            
            Assert.AreEqual(0, result.Length);
        }

        [Test]
        public void Test3()
        {
            int testNumber = 2;
            var result = PrimeNumberFactorial.GetPrimeNumberFactorial(testNumber);
            
            Assert.AreEqual("2x1", result[0]);
        }

        [Test]
        public void Test4()
        {
            int testNumber = 5;
            var result = PrimeNumberFactorial.GetPrimeNumberFactorial(testNumber);
            
            Assert.AreEqual("5x1", result[0]);
        }

        [Test]
        public void Test5()
        {
            int testNumber = 2 * 3 * 5 * 7;
            var result = PrimeNumberFactorial.GetPrimeNumberFactorial(testNumber);
            
            Assert.AreEqual("2x1", result[0]);
            Assert.AreEqual("3x1", result[1]);
            Assert.AreEqual("5x1", result[2]);
            Assert.AreEqual("7x1", result[3]);
        }
    }
}