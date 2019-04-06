using System;
using System.Collections.Generic;
using InterviewQuestions.Challenges.Challenge1;

namespace InterviewQuestions.Challenges.Challenge2
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BSTNode<T> RootNode { get; private set; }

        public void InsertData(T data)
        {
            var newNode = new BSTNode<T>(data);
            if (RootNode == null)
            {
                RootNode = newNode;
                return;
            }

            var currentNode = RootNode;
            while (currentNode != null)
            {
                // If new node is smaller than current node
                if (data.CompareTo(currentNode.Data) < 0)
                {
                    if (currentNode.LeftChild == null)
                    {
                        currentNode.LeftChild = newNode;
                        return;
                    }
                    currentNode = currentNode.LeftChild;
                }
                else
                {
                    if (currentNode.RightChild == null)
                    {
                        currentNode.RightChild = newNode;
                        return;
                    }
                    currentNode = currentNode.RightChild;
                }
            }
        }

        public bool Contains(T data)
        {
            var currentNode = RootNode;

            while (currentNode != null)
            {
                if (data.CompareTo(currentNode.Data) < 0)
                {
                    if (currentNode.Data.Equals(data))
                    {
                        return true;
                    }
                    currentNode = currentNode.LeftChild;
                }
                else
                {
                    if (currentNode.Data.Equals(data))
                    {
                        return true;
                    }
                    currentNode = currentNode.RightChild;
                }
            }

            return false;
        }

        public T[] InOrderTraversal()
        {
            List<T> returnList = new List<T>();
            InOrderTraversal(RootNode, returnList);
            return returnList.ToArray();
        }

        private void InOrderTraversal(BSTNode<T> currentNode, List<T> returnList)
        {
            if (currentNode == null)
            {
                return;
            }

            InOrderTraversal(currentNode.LeftChild, returnList);
            returnList.Add(currentNode.Data);
            InOrderTraversal(currentNode.RightChild, returnList);
        }

        public T[] PreOrderTraversal()
        {
            List<T> returnList = new List<T>();
            PreOrderTraversal(RootNode, returnList);
            return returnList.ToArray();
        }

        private void PreOrderTraversal(BSTNode<T> currentNode, List<T> returnList)
        {
            if (currentNode == null)
            {
                return;
            }

            returnList.Add(currentNode.Data);
            PreOrderTraversal(currentNode.LeftChild, returnList);
            PreOrderTraversal(currentNode.RightChild, returnList);
        }

        public T[] PostOrderTraversal()
        {
            List<T> returnList = new List<T>();
            PostOrderTraversal(RootNode, returnList);
            return returnList.ToArray();
        }

        private void PostOrderTraversal(BSTNode<T> currentNode, List<T> returnList)
        {
            if (currentNode == null)
            {
                return;
            }

            PostOrderTraversal(currentNode.LeftChild, returnList);
            PostOrderTraversal(currentNode.RightChild, returnList);
            returnList.Add(currentNode.Data);
        }

        public void Balance()
        {
            // Fetch the unbalanced BST from an InOrderTraversal
            T[] data = InOrderTraversal();
            RootNode = null;

            // Recursively add these items to the BST
            Add(data, 0, data.Length);
        }

        private void Add(T[] data, int startIndex, int endIndex)
        {
            // (0, 1, 2, 3, 4, 5, 6, 7) = 4
            // (0, 1, 2, 3) - (5, 6, 7) = 2 - 6
            // (0, 1) - (3) - (5) - (7) = 1 - 3 - 5 - 7

            if (endIndex <= startIndex)
            {
                return;
            }
            
            int midValue = (startIndex + endIndex) / 2;
            InsertData(data[midValue]);
            Add(data, startIndex, midValue - 1);
            Add(data, midValue + 1, endIndex);            
        }

        public void Swap(int[] heights)
        {
            HashSet<int> height = new HashSet<int>();
            for (int i = 0; i < heights.Length; i++)
            {
                height.Add(heights[i]);
            }
            SwapRecursive(RootNode, 0, height);
        }

        private void SwapRecursive(BSTNode<T> currentNode, int currentHeight, HashSet<int> heights)
        {
            if (currentNode == null)
            {
                return;
            }

            if (heights.Contains(currentHeight))
            {
                var cachedLeftNode = currentNode.LeftChild;
                currentNode.LeftChild = currentNode.RightChild;
                currentNode.RightChild = cachedLeftNode; 
            }

            currentHeight++;
            SwapRecursive(currentNode.LeftChild, currentHeight, heights);
            SwapRecursive(currentNode.RightChild, currentHeight, heights);
        }
    }
    
    public class BSTNode<T>
    {
        public readonly T Data;
        public BSTNode<T> LeftChild;
        public BSTNode<T> RightChild;

        public BSTNode(T data)
        {
            Data = data;
        }
    }

    public class ItemDoesNotExistException : Exception
    {
    }
}