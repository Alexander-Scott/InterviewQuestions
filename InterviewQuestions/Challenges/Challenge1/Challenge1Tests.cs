using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge1
{
    [TestFixture]
    public class Challenge1Tests
    {
        [Test]
        public void InsertData()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(5);
            
            Assert.AreEqual(5, linkedList.Tail.Data);
            Assert.AreEqual(5, linkedList.Head.Data);
        }

        [Test]
        public void InsertMultipleData()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(5);
            linkedList.Insert(6);
            linkedList.Insert(7);

            Assert.AreEqual(5, linkedList.Head.Data);
            Assert.AreEqual(7, linkedList.Tail.Data);
        }

        [Test]
        public void RetrieveNodeFromLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(5);
            linkedList.Insert(6);
            linkedList.Insert(7);

            var fetchedNode = linkedList.GetNodeWithData(6);
            Assert.AreEqual(6, fetchedNode.Data);
        }

        [Test]
        public void TestForLoopDetection()
        {
            var linkedList = new LinkedList<int>();
            var node1 = new LinkedListNode<int>(5);
            var node2 = new LinkedListNode<int>(6);
            var node3 = new LinkedListNode<int>(7);
            var node4 = new LinkedListNode<int>(8);
            var node5 = new LinkedListNode<int>(9);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node1; // Loop created here

            linkedList.Head = node1;
            linkedList.Tail = node5;

            var loopExists = linkedList.HasLoop();
            Assert.AreEqual(true, loopExists);

            node5.Next = null;
            loopExists = linkedList.HasLoop();
            Assert.AreEqual(false, loopExists);
        }

        [Test]
        public void ConvertLinkedListToArray()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(5);
            linkedList.Insert(6);
            linkedList.Insert(7);
            linkedList.Insert(8);
            linkedList.Insert(9);

            var getArray = linkedList.GetAsArray();
            Assert.AreEqual(5, getArray[0]);
            Assert.AreEqual(6, getArray[1]);
            Assert.AreEqual(7, getArray[2]);
            Assert.AreEqual(8, getArray[3]);
            Assert.AreEqual(9, getArray[4]);
        }

        [Test]
        public void ReverseLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(5);
            linkedList.Insert(6);
            linkedList.Insert(7);
            linkedList.Insert(8);
            linkedList.Insert(9);

            linkedList.Reverse();

            var getArray = linkedList.GetAsArray();
            Assert.AreEqual(9, getArray[0]);
            Assert.AreEqual(8, getArray[1]);
            Assert.AreEqual(7, getArray[2]);
            Assert.AreEqual(6, getArray[3]);
            Assert.AreEqual(5, getArray[4]);
        }

        [Test]
        public void FixLoopInLinkedList()
        {
            var linkedList = new LinkedList<int>();
            var node1 = new LinkedListNode<int>(5);
            var node2 = new LinkedListNode<int>(6);
            var node3 = new LinkedListNode<int>(7);
            var node4 = new LinkedListNode<int>(8);
            var node5 = new LinkedListNode<int>(9);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node3; // Loop created here

            linkedList.Head = node1;
            linkedList.Tail = node5;

            var loopExists = linkedList.HasLoop();
            Assert.AreEqual(true, loopExists);

            linkedList.RemoveLoop();
            loopExists = linkedList.HasLoop();
            Assert.AreEqual(false, loopExists);
        }

        [Test]
        public void SortLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Insert(6);
            linkedList.Insert(8);
            linkedList.Insert(2);
            linkedList.Insert(9);
            linkedList.Insert(3);
            linkedList.Insert(5);
            linkedList.Insert(7);
            linkedList.Insert(1);
            linkedList.Insert(4);

            linkedList.Sort();
            
            Assert.AreEqual(1, linkedList.Head.Data);
            Assert.AreEqual(9, linkedList.Tail.Data);
        }
    }
}