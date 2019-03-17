using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge1
{
    [TestFixture]
    public class Challenge1Tests
    {
        [Test]
        public void AddNodeToLinkedListEnd()
        {
            var linkedList = new LinkedList<int>();
            var node = new LinkedListNode<int>(5);

            linkedList.AddNodeToEnd(node);
            Assert.AreEqual(node.Data, linkedList.Tail.Data);
        }
        
        [Test]
        public void AddNodeToLinkedListStart()
        {
            var linkedList = new LinkedList<int>();
            var node = new LinkedListNode<int>(5);

            linkedList.AddNodeToBeginning(node);
            Assert.AreEqual(node.Data, linkedList.Head.Data);
        }

        [Test]
        public void AddManyNodesToLinkedList()
        {
            var linkedList = new LinkedList<int>();
            var node1 = new LinkedListNode<int>(5);
            var node2 = new LinkedListNode<int>(6);
            var node3 = new LinkedListNode<int>(7);

            linkedList.AddNodeToEnd(node1);
            linkedList.AddNodeToEnd(node2);
            linkedList.AddNodeToEnd(node3);
            
            Assert.AreEqual(node1.Data, linkedList.Head.Data);
            Assert.AreEqual(node3.Data, linkedList.Tail.Data);
        }

        [Test]
        public void RetrieveNodeFromLinkedList()
        {
            var linkedList = new LinkedList<int>();
            var node1 = new LinkedListNode<int>(5);
            var node2 = new LinkedListNode<int>(6);
            var node3 = new LinkedListNode<int>(7);

            linkedList.AddNodeToEnd(node1);
            linkedList.AddNodeToEnd(node2);
            linkedList.AddNodeToEnd(node3);

            var fetchedNode = linkedList.GetNodeWithData(6);
            Assert.AreEqual(node2, fetchedNode);
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

            linkedList.Tail.Next = null;
            loopExists = linkedList.HasLoop();
            Assert.AreEqual(false, loopExists);
        }

        [Test]
        public void ConvertLinkedListToArray()
        {
            var linkedList = new LinkedList<int>();
            var node1 = new LinkedListNode<int>(5);
            var node2 = new LinkedListNode<int>(6);
            var node3 = new LinkedListNode<int>(7);
            var node4 = new LinkedListNode<int>(8);
            var node5 = new LinkedListNode<int>(9);
            
            linkedList.AddNodeToEnd(node1);
            linkedList.AddNodeToEnd(node2);
            linkedList.AddNodeToEnd(node3);
            linkedList.AddNodeToEnd(node4);
            linkedList.AddNodeToEnd(node5);

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
            var node1 = new LinkedListNode<int>(5);
            var node2 = new LinkedListNode<int>(6);
            var node3 = new LinkedListNode<int>(7);
            var node4 = new LinkedListNode<int>(8);
            var node5 = new LinkedListNode<int>(9);
            
            linkedList.AddNodeToEnd(node1);
            linkedList.AddNodeToEnd(node2);
            linkedList.AddNodeToEnd(node3);
            linkedList.AddNodeToEnd(node4);
            linkedList.AddNodeToEnd(node5);

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
    }
}