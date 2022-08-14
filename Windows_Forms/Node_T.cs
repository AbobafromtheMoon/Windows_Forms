using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms
{
    class Node<T> where T : IComparable<T>
    {
        public T Element
        {
            get;
            set;
        }

        public Node<T> Previous
        {
            get;
            set;
        }

        public Node<T> Next
        {
            get;
            set;
        }

        public Node(T element)
        {
            Element = element;
        }

        public Node() { }

        public override string ToString()
        {
            return Element.ToString();
        }

        public void SetNextNode(Node<T> _nextNode)
        {
            Next = _nextNode;
        }
        // переопределили операторы сравнения 
        public static bool operator >(Node<T> n1, Node<T> n2)
        {
            if (n1.Element.CompareTo(n2.Element) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Node<T> n1, Node<T> n2)
        {
            if (n1.Element.CompareTo(n2.Element) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Node<T> n1, Node<T> n2)
        {
            int compare = n1.Element.CompareTo(n2.Element);
            if (compare <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Node<T> n1, Node<T> n2)
        {
            int compare = n1.Element.CompareTo(n2.Element);
            if (compare >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
