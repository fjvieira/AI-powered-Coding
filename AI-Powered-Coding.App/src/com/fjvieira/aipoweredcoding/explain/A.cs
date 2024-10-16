using System;

namespace com.fjvieira.aipoweredcoding.explain
{
    public class A<E>
    {
        private Node<E>? head;
        private Node<E>? tail;

        public void AppendToTail(E value)
        {
            Node<E> nNode = new Node<E>(value, tail, null);
            if (head == null)
            {
                head = nNode;
            }

            if (tail != null)
            {
                tail.Next = nNode;
            }

            tail = nNode;
        }

        public void AppendToHead(E value)
        {
            Node<E> nNode = new Node<E>(value, null, head);
            if (tail == null)
            {
                tail = nNode;
            }

            if (head != null)
            {
                head.Previous = nNode;
            }

            head = nNode;
        }

        public E? PeekTail()
        {
            return tail == null ? default : tail.Value;
        }

        public E? PeekHead()
        {
            return head == null ? default(E) : head.Value;
        }

        public E? PullTail()
        {
            if (tail == null)
            {
                return default;
            }
            Node<E> oldTail = tail;
            tail = oldTail.Previous;
            if (tail != null)
            {
                tail.Next = null;
            }
            else
            {
                head = null;
            }

            return oldTail.Value;
        }

        public E? PullHead()
        {
            if (head == null)
            {
                return default;
            }
            Node<E> oldHead = head;
            head = head.Next;
            if (head != null)
            {
                head.Previous = null;
            }
            else
            {
                tail = null;
            }

            return oldHead.Value;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        protected class Node<T>
        {
            public T Value { get; set; }
            public Node<T>? Previous { get; set; }
            public Node<T>? Next { get; set; }

            public Node(T value, Node<T>? previous, Node<T>? next)
            {
                Value = value;
                Previous = previous;
                Next = next;
            }
        }
    }
}