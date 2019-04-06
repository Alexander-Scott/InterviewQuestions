using System;

namespace InterviewQuestions.Challenges.Challenge11
{
    interface IStack<T>
    {
        int Count { get; }
        void Push(T data);
        T Pop();
        T Peek();
        void Clear();
        void Reverse();
    }

    public class LinkedListStack<T> : IStack<T>
    {
        public int Count { get; private set; }

        private LinkedListStackNode<T> _tailNode;

        public LinkedListStack()
        {
            _tailNode = null;
        }

        public void Push(T data)
        {
            var newNode = new LinkedListStackNode<T>(data);
            Count++;

            if (_tailNode == null)
            {
                _tailNode = newNode;
                return;
            }

            newNode.NextNode = _tailNode;
            _tailNode = newNode;
        }

        public T Pop()
        {
            if (_tailNode == null)
            {
                throw new EmptyStackException();
            }

            T data = _tailNode.Data;
            _tailNode = _tailNode.NextNode;
            Count--;

            return data;
        }

        public T Peek()
        {
            if (_tailNode == null)
            {
                throw new EmptyStackException();
            }

            return _tailNode.Data;
        }

        public void Clear()
        {
            Count = 0;
            _tailNode = null;
        }

        public void Reverse()
        {
            var prevNode = _tailNode;
            var currentNode = _tailNode.NextNode;

            prevNode.NextNode = null;

            while (currentNode != null)
            {
                var cachedNext = currentNode.NextNode;
                currentNode.NextNode = prevNode;
                prevNode = currentNode;
                currentNode = cachedNext;
            }

            _tailNode = prevNode;
        }
    }

    public class LinkedListStackNode<T>
    {
        public readonly T Data;
        public LinkedListStackNode<T> NextNode;

        public LinkedListStackNode(T data)
        {
            Data = data;
        }
    }

    public class ArrayStack<T> : IStack<T>
    {
        private T[] _data;

        public int Count => _data.Length;

        public ArrayStack()
        {
            _data = new T[0];
        }

        public void Push(T data)
        {
            if (_data == null || _data.Length == 0)
            {
                _data = new[] {data};
                return;
            }
            
            T[] newData = new T[_data.Length + 1];
            _data.CopyTo(newData, 0);
            newData[newData.Length - 1] = data;
            _data = newData;
        }

        public T Pop()
        {
            if (_data == null || _data.Length == 0)
            {
                throw new EmptyStackException();
            }

            T data = _data[_data.Length - 1];
            T[] newData = new T[_data.Length - 1];
            Array.Copy(_data, 0, newData, 0, _data.Length - 1);
            _data = newData;
            return data;
        }

        public T Peek()
        {
            if (_data == null || _data.Length == 0)
            {
                throw new EmptyStackException();
            }
            
            return _data[_data.Length - 1];
        }

        public void Clear()
        {
            _data = new T[0];
        }

        public void Reverse()
        {
            T[] newData = new T[_data.Length];
            int count = 0;
            for (int i = _data.Length - 1; i >= 0; i--)
            {
                newData[count] = _data[i];
                count++;
            }

            _data = newData;
        }
    }

    public class EmptyStackException : Exception
    {
    }
}