using System;

namespace InterviewQuestions.Challenges.Challenge1
{   
    public class LinkedList<T>
    {
        public LinkedListNode<T> Head;
        public LinkedListNode<T> Tail;
        
        public LinkedList()
        {
            throw new NotImplementedException();
        }

        public void Insert(T data)
        {
            throw new NotImplementedException();
        }

        public LinkedListNode<T> GetNodeWithData(T data)
        {
            throw new NotImplementedException();
        }

        public bool HasLoop()
        {
            throw new NotImplementedException();
        }

        public T[] GetAsArray()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {          
            throw new NotImplementedException();
        }

        public void RemoveLoop()
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
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