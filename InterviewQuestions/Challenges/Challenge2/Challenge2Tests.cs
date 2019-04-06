using NUnit.Framework;

namespace InterviewQuestions.Challenges.Challenge2
{
    [TestFixture]
    public class Challenge2Tests
    {
        /// <summary>
        /// Creates a new BST and makes sure the root node is null
        /// </summary>
        [Test]
        public void CreateObject()
        {
            var binarySearchTree = new BinarySearchTree<int>();
            Assert.AreEqual(null, binarySearchTree.RootNode);
        }

        /// <summary>
        /// Inserts multiple values into the BST and checks they are assigned to the correct nodes
        /// </summary>
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

        /// <summary>
        /// Fetches a node from the BST
        /// </summary>
        [Test]
        public void Contains()
        {
            var binarySearchTree = new BinarySearchTree<int>();
            for (var i = 0; i < 500; i++)
            {
                binarySearchTree.InsertData(i);
            }

            bool test1 = binarySearchTree.Contains(58);
            bool test2 = binarySearchTree.Contains(97);
            bool test3 = binarySearchTree.Contains(322);
            bool test4 = binarySearchTree.Contains(503);
            bool test5 = binarySearchTree.Contains(-100);
            bool test6 = binarySearchTree.Contains(0);
            
            Assert.AreEqual(true, test1);
            Assert.AreEqual(true, test2);
            Assert.AreEqual(true, test3);
            Assert.AreEqual(false, test4);
            Assert.AreEqual(false, test5);
            Assert.AreEqual(true, test6);
        }

        /// <summary>
        /// Traverses the BST InOrder and returns it as an array
        /// </summary>
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
             *             3
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
        
        /// <summary>
        /// Traverses the BST PreOrder and returns it as an array
        /// </summary>
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
        
        /// <summary>
        /// Traverses the BST PostOrder and returns it as an array
        /// </summary>
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

        /// <summary>
        /// Balances an unbalanced BST. To balance a BST, the height of all leaf nodes must
        /// have a difference of 0 or 1.
        /// </summary>
        [Test]
        public void BalanceBst()
        {
            var binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertData(0);
            binarySearchTree.InsertData(1);
            binarySearchTree.InsertData(2);
            binarySearchTree.InsertData(3);
            binarySearchTree.InsertData(4);
            binarySearchTree.InsertData(5);
            binarySearchTree.InsertData(6);
            binarySearchTree.InsertData(7);
            
            /*
             *  0
             *   1
             *    2
             *     3
             *      4
             *       5
             *        6
             *         7
             */
            
            Assert.AreEqual(0, binarySearchTree.RootNode.Data);

            binarySearchTree.Balance();
            
            /*
             *          4
             *      1       6
             *    0  2    5   7
             *        3
             */
            
            Assert.AreEqual(4, binarySearchTree.RootNode.Data);
            Assert.AreEqual(1, binarySearchTree.RootNode.LeftChild.Data);
            Assert.AreEqual(6, binarySearchTree.RootNode.RightChild.Data);            
        }

        /// <summary>
        /// Swaps the subtrees at specified node heights.
        /// Swapping subtrees of a node means that if initially node has left subtree L
        /// and right subtree R, then after swapping, the left subtree will be R and the right subtree, L.
        /// </summary>
        [Test]
        public void SwapTest()
        {
            var binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertData(3);
            binarySearchTree.InsertData(2);
            binarySearchTree.InsertData(1);
            binarySearchTree.InsertData(5);
            binarySearchTree.InsertData(4);
            binarySearchTree.InsertData(6);
            
            /*
             *        3
             *     2     5
             *  1      4   6
             * 
             */

            int[] heights = {0, 1, 2};
            binarySearchTree.Swap(heights);
            
            /*
             *        3
             *     5     2
             *   6  4      1
             * 
             */
            
            Assert.AreEqual(3, binarySearchTree.RootNode.Data);
            Assert.AreEqual(5, binarySearchTree.RootNode.LeftChild.Data);
            Assert.AreEqual(4, binarySearchTree.RootNode.LeftChild.RightChild.Data);
            Assert.AreEqual(6, binarySearchTree.RootNode.LeftChild.LeftChild.Data);
            Assert.AreEqual(2, binarySearchTree.RootNode.RightChild.Data);
            Assert.AreEqual(1, binarySearchTree.RootNode.RightChild.RightChild.Data);
        }
    }
}