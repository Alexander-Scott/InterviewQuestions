using System;
using System.Collections.Generic;

namespace InterviewQuestions.Challenges.Challenge2
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BSTNode<T> RootNode;

        public BinarySearchTree()
        {
            throw new NotImplementedException();
        }

        public BSTNode<T> InsertData(T data)
        {
            throw new NotImplementedException();
        }

        public BSTNode<T> FetchNode(T data)
        {
            throw new NotImplementedException();
        }

        public T[] InOrderTraversal()
        {
            throw new NotImplementedException();
        }

        private void InOrderTraversalRecursive(BSTNode<T> currentNode, List<T> traversalResults)
        {
            throw new NotImplementedException();
        }

        public T[] PreOrderTraversal()
        {
            throw new NotImplementedException();
        }
        
        private void PreOrderTraversalRecursive(BSTNode<T> currentNode, List<T> traversalResults)
        {
            throw new NotImplementedException();
        }

        public T[] PostOrderTraversal()
        {
            throw new NotImplementedException();
        }
        
        private void PostOrderTraversalRecursive(BSTNode<T> currentNode, List<T> traversalResults)
        {
            throw new NotImplementedException();
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