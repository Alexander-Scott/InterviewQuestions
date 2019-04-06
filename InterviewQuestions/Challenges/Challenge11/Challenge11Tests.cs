using System;
using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge11
{
    [TestFixture]
    public class Challenge11Tests
    {
        [Test]
        public void PushPopTestLinkedList()
        {
            PopTest(new LinkedListStack<int>());
        }
        
        [Test]
        public void PushPopTestArray()
        {
            PopTest(new ArrayStack<int>());
        }

        private static void PopTest(IStack<int> stack)
        {
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            int poppedItem = stack.Pop();
            Assert.AreEqual(7, poppedItem);
            poppedItem = stack.Pop();
            Assert.AreEqual(6, poppedItem);
            poppedItem = stack.Pop();
            Assert.AreEqual(5, poppedItem);
        }

        [Test]
        public void PeekTestLinkedList()
        {
            PeekTest(new LinkedListStack<int>());
        }
        
        [Test]
        public void PeekTestArray()
        {
            PeekTest(new ArrayStack<int>());
        }
        
        private void PeekTest(IStack<int> stack)
        {
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            int peekedItem = stack.Peek();
            Assert.AreEqual(7, peekedItem);

            int poppedItem = stack.Pop();
            Assert.AreEqual(7, poppedItem);
        }
        
        [Test]
        public void CountTestLinkedList()
        {
            CountTest(new LinkedListStack<int>());
        }
        
        [Test]
        public void CountTestArray()
        {
            CountTest(new ArrayStack<int>());
        }

        private void CountTest(IStack<int> stack)
        {
            int stackCount = stack.Count;
            Assert.AreEqual(0, stackCount);

            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            stackCount = stack.Count;
            Assert.AreEqual(3, stackCount);

            stack.Pop();

            stackCount = stack.Count;
            Assert.AreEqual(2, stackCount);
        }
        
        [Test]
        public void ClearTestLinkedList()
        {
            ClearTest(new LinkedListStack<int>());
        }
        
        [Test]
        public void ClearTestArray()
        {
            ClearTest(new ArrayStack<int>());
        }

        private void ClearTest(IStack<int> stack)
        {
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            int stackCount = stack.Count;
            Assert.AreEqual(3, stackCount);

            stack.Clear();
            
            stackCount = stack.Count;
            Assert.AreEqual(0, stackCount);
            
            stack.Push(8);
            
            stackCount = stack.Count;
            Assert.AreEqual(1, stackCount);

            int poppedNumber = stack.Pop();
            Assert.AreEqual(8, poppedNumber);
            
            stackCount = stack.Count;
            Assert.AreEqual(0, stackCount);
        }
        
        [Test]
        public void ExceptionsTestLinkedList()
        {
            ExceptionsTest(new LinkedListStack<int>());
        }
        
        [Test]
        public void ExceptionsTestArray()
        {
            ExceptionsTest(new ArrayStack<int>());
        }

        private void ExceptionsTest(IStack<int> stack)
        {
            Assert.Throws<EmptyStackException>(() => stack.Pop());
            Assert.Throws<EmptyStackException>(() => stack.Peek());
        }
        
        [Test]
        public void ReverseTestLinkedList()
        {
            ReverseTest(new LinkedListStack<int>());
        }
        
        [Test]
        public void ReverseTestArray()
        {
            ReverseTest(new ArrayStack<int>());
        }

        private void ReverseTest(IStack<int> stack)
        {
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            stack.Reverse();

            int poppedItem = stack.Pop();
            Assert.AreEqual(5, poppedItem);
        }
    }
}