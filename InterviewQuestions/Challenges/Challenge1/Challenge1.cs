using System;
using System.Collections.Generic;

namespace InterviewQuestions.Challenges.Challenge1
{
    public class LinkedList<T> where T : IComparable<T>
    {
        public LinkedListNode<T> Head;
        public LinkedListNode<T> Tail;

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void Insert(T data)
        {
            var newNode = new LinkedListNode<T>(data);
            // If the linked list is empty
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            
            // Add to the current tail
            Tail.Next = newNode;
            Tail = newNode;
        }

        public LinkedListNode<T> GetNodeWithData(T data)
        {
            if (Head == null)
            {
                throw new EmptyLinkedListException();
            }
            return GetNodeWithDataRecursive(data, Head);
        }

        private LinkedListNode<T> GetNodeWithDataRecursive(T data, LinkedListNode<T> currentNode)
        {
            if (currentNode == null)
            {
                throw new NodeDoesNotExistException();
            }
            
            if (currentNode.Data.Equals(data))
            {
                return currentNode;
            }

            return GetNodeWithDataRecursive(data, currentNode.Next);
        }

        public bool HasLoop()
        {
            LinkedListNode<T> slowPointer = Head;
            LinkedListNode<T> fastPointer = Head;

            while (slowPointer != null && fastPointer != null)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next;
                fastPointer = fastPointer?.Next;
                
                if (slowPointer == fastPointer)
                {
                    return true;
                }
            }

            return false;
        }
        
        public T[] GetAsArray()
        {
            List<T> returnList = new List<T>();
            GetAsArrayRecursive(Head, returnList);
            return returnList.ToArray();
        }

        private void GetAsArrayRecursive(LinkedListNode<T> currentNode, List<T> returnList)
        {
            if (currentNode == null)
            {
                return;
            }
            
            returnList.Add(currentNode.Data);
            GetAsArrayRecursive(currentNode.Next, returnList);
        }

        /// <summary>
        /// Iterate through the nodes.
        /// Cache the next node of the current node.
        /// Set the current node's next pointer to the previous
        /// Set the previous node to be the current node.
        /// Set the current node to be the cached next node.
        /// </summary>
        public void Reverse()
        {
            LinkedListNode<T> prev = Head;
            LinkedListNode<T> current = Head.Next;
            
            Head.Next = null;
            Tail = Head;

            while (current != null)
            {
                LinkedListNode<T> cachedNextNode = current.Next;
                current.Next = prev;
                prev = current;
                current = cachedNextNode;
            }

            Head = prev;
        }

        public void RemoveLoop()
        {
            LinkedListNode<T> currentNode = Head;
            LinkedListNode<T> previousNode = null;
            HashSet<LinkedListNode<T>> existingNodes = new HashSet<LinkedListNode<T>>();

            while (currentNode != null)
            {
                // Check if the node has already been added
                if (existingNodes.Contains(currentNode))
                {
                    if (previousNode != null) 
                        previousNode.Next = null;
                    return;
                }

                existingNodes.Add(currentNode);
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }

        public void Sort()
        {
            T[] array = GetAsArray();
            Array.Sort(array);
            Head = null;
            
            for (int i = 0; i < array.Length; i++)
            {
                Insert(array[i]);    
            }
        }
    }

    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next;
        public readonly T Data;

        public LinkedListNode(T data)
        {
            Data = data;
        }
    }

    public class NodeDoesNotExistException : Exception
    {
    }

    public class EmptyLinkedListException : Exception
    {
    }
}