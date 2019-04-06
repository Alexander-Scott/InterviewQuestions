using System;
using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge12
{
    [TestFixture]
    public class Challenge12Tests
    {
        [Test]
        public void QuickSortTest()
        {
            Random rand = new Random();
            int[] data1 = new int[1000];
            int[] data2 = new int[1000];
            for (int i = 0; i < data1.Length; i++)
            {
                int randVal = rand.Next(100000);
                data1[i] = randVal;
                data2[i] = randVal;
            }
            
            SorterClass.QuickSort(data1);
            Array.Sort(data2);

            for (int i = 0; i < data1.Length; i++)
            {
                Assert.AreEqual(data2[i], data1[i]);
            }            
        }

        [Test]
        public void MergeSortTest()
        {
            Random rand = new Random();
            int[] data1 = new int[1000];
            int[] data2 = new int[1000];
            for (int i = 0; i < data1.Length; i++)
            {
                int randVal = rand.Next(100000);
                data1[i] = randVal;
                data2[i] = randVal;
            }
            
            SorterClass.MergeSort(data1);
            Array.Sort(data2);

            for (int i = 0; i < data1.Length; i++)
            {
                Assert.AreEqual(data2[i], data1[i]);
            }   
        }
    }
}