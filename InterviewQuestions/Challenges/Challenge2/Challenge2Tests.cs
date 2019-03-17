using System.Collections.Generic;
using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge2
{
    [TestFixture]
    public class Challenge2Tests
    {
        [Test]
        public void CreateObject()
        {
            var binarySearchTree = new BinarySearchTree<int>();
            Assert.AreEqual(null, binarySearchTree.RootNode);
        }

        [Test]
        public void InsertMultiple()
        {
            var binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertData(5);
            binarySearchTree.InsertData(8);
            binarySearchTree.InsertData(3);
            binarySearchTree.InsertData(4);
            binarySearchTree.InsertData(9);
            binarySearchTree.InsertData(1);
            binarySearchTree.InsertData(2);

            Assert.AreEqual(5, binarySearchTree.RootNode.Data);
            Assert.AreEqual(8, binarySearchTree.RootNode.RightChild.Data);
            Assert.AreEqual(3, binarySearchTree.RootNode.LeftChild.Data);
            Assert.AreEqual(9, binarySearchTree.RootNode.RightChild.RightChild.Data);
            Assert.AreEqual(2, binarySearchTree.RootNode.LeftChild.LeftChild.RightChild.Data);
        }

        [Test]
        public void FetchNode()
        {
            var binarySearchTree = new BinarySearchTree<int>();
            var dictionary = new Dictionary<int, BSTNode<int>>();
            for (var i = 0; i < 500; i++)
            {
                dictionary.Add(i, binarySearchTree.InsertData(i));
            }

            var node1 = binarySearchTree.FetchNode(58);
            var node2 = binarySearchTree.FetchNode(97);
            var node3 = binarySearchTree.FetchNode(322);
            
            Assert.AreEqual(dictionary[58], node1);
            Assert.AreEqual(dictionary[97], node2);
            Assert.AreEqual(dictionary[322], node3);
        }
        
        [Test]
        public void TryFetchNode()
        {
            var binarySearchTree = new BinarySearchTree<int>();
            for (var i = 0; i < 100; i++)
            {
                binarySearchTree.InsertData(i);
            }

            Assert.Throws<ItemDoesNotExistException>(() => binarySearchTree.FetchNode(123));
        }

        [Test]
        public void InOrderTraversal()
        {
            var binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertData(3);
            binarySearchTree.InsertData(2);
            binarySearchTree.InsertData(1);
            binarySearchTree.InsertData(5);
            binarySearchTree.InsertData(4);
            binarySearchTree.InsertData(6);
            
            /* LEFT-ROOT-RIGHT
             *            3
             *          2     5
             *       1      4   6
             * 1,2,3,4,5,6
             */

            var traversalResults = binarySearchTree.InOrderTraversal();
            Assert.AreEqual(1, traversalResults[0]);
            Assert.AreEqual(2, traversalResults[1]);
            Assert.AreEqual(3, traversalResults[2]);
            Assert.AreEqual(4, traversalResults[3]);
            Assert.AreEqual(5, traversalResults[4]);
            Assert.AreEqual(6, traversalResults[5]);
        }
        
        [Test]
        public void PreOrderTraversal()
        {
            var binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertData(3);
            binarySearchTree.InsertData(2);
            binarySearchTree.InsertData(1);
            binarySearchTree.InsertData(5);
            binarySearchTree.InsertData(4);
            binarySearchTree.InsertData(6);
            
            /* ROOT-LEFT-RIGHT
             *            3
             *          2     5
             *       1      4   6
             * 3,2,1,5,4,6
             */
            
            var traversalResults = binarySearchTree.PreOrderTraversal();
            Assert.AreEqual(3, traversalResults[0]);
            Assert.AreEqual(2, traversalResults[1]);
            Assert.AreEqual(1, traversalResults[2]);
            Assert.AreEqual(5, traversalResults[3]);
            Assert.AreEqual(4, traversalResults[4]);
            Assert.AreEqual(6, traversalResults[5]);
        }
        
        [Test]
        public void PostOrderTraversal()
        {
            var binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertData(3);
            binarySearchTree.InsertData(2);
            binarySearchTree.InsertData(1);
            binarySearchTree.InsertData(5);
            binarySearchTree.InsertData(4);
            binarySearchTree.InsertData(6);
            
            /* LEFT-RIGHT-ROOT
             *            3
             *          2     5
             *       1      4   6
             * 1,2,4,6,5,3
             */
            
            var traversalResults = binarySearchTree.PostOrderTraversal();
            Assert.AreEqual(1, traversalResults[0]);
            Assert.AreEqual(2, traversalResults[1]);
            Assert.AreEqual(4, traversalResults[2]);
            Assert.AreEqual(6, traversalResults[3]);
            Assert.AreEqual(5, traversalResults[4]);
            Assert.AreEqual(3, traversalResults[5]);
        }
    }
}