using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms
{
    class vector<T> where T : IComparable<T>
    {
        public Node<T> headNode;
        public Node<T> tailNode;

        public Node<T> Cur;
        public int Ncur;

        public int Length;
        public vector()
        {
            this.headNode = null;
            this.tailNode = this.headNode;
            this.Length = 0;
        }
        public Node<T> this[int _position]
        {
            get //чтение 
            {
                Node<T> tempNode = new Node<T>(); //выделение памяти под текущий элемен 
                tempNode.Element = default(T);
                if (_position < this.Length) //Если индекс меньше размера списка 
                {
                    if (Math.Abs(Ncur - _position) < Math.Abs(this.Length / 2 - _position) || Math.Abs(Ncur - _position) < Math.Abs(this.Length / 2 + 1 - _position))
                    {
                        if (Cur == null) Cur = headNode;
                        tempNode = Cur;
                        if ((_position - Ncur) < 0)
                        {
                            for (int i = Ncur; i > _position + 1; i--) tempNode = tempNode.Previous; //Ссылаюсь на предыдущий элемент 
                        }
                        if ((_position - Ncur) > 0)
                        {
                            for (int i = Ncur; i < _position; i++) tempNode = tempNode.Next; //Ссылаюсь на следующий элемент 
                        }
                    }
                    if (_position <= this.Length / 2)
                    {
                        tempNode = headNode;
                        for (int i = 0; i < _position; i++) tempNode = tempNode.Next; //Ссылаюсь на следующий элемент 
                    }
                    if (_position > this.Length / 2)
                    {
                        tempNode = tailNode;
                        for (int i = this.Length; i > _position + 1; i--) tempNode = tempNode.Previous; //Ссылаюсь на предыдущий элемент 
                    }
                    Cur = tempNode;
                    Ncur = _position;
                }
                return tempNode;
            }
        }
        public void Push(T element)
        {
            Node<T> node = new Node<T>(element);

            if (headNode == null)
                headNode = node;
            else
            {
                tailNode.Next = node;
                node.Previous = tailNode;
            }
            tailNode = node;
            Length++;
        }
        public void InsertA(int pos, Node<T> node)
        {
            if (pos < Length)
            {
                Node<T> cur = headNode;
                for (int i = 0; i < pos; ++i)
                {
                    cur = cur.Next;
                }
                if (cur != headNode)
                {
                    cur.Previous.Next = node;
                }
                else
                {
                    headNode = node;
                }
                node.Previous = cur.Previous;
                node.Next = cur;
                cur.Previous = node;
                Length++;
            }
        }
        public void InsertAt(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.Element = value;
            if (Length == 0)
            {
                this.headNode = newNode;
                this.tailNode = newNode;
            }
            else
            {
                tailNode.Next = newNode;
                newNode.Previous = tailNode;
                this.tailNode = newNode;
            }
            this.Length++;
        }

        public void RemoveAt(int pos)
        {
            Node<T> cur = headNode;
            for (int i = 0; i < pos; ++i)
            {
                cur = cur.Next;
            }
            if (cur != headNode)
            {
                cur.Previous.Next = cur.Next;
            }
            else
            {
                headNode = headNode.Next;
            }
            if (cur != tailNode)
            {
                cur.Next.Previous = cur.Previous;
            }
            else
            {
                tailNode = tailNode.Previous;
            }
            cur.Next = null;
            cur.Previous = null;
            Length--;
        }

        public void swap(int pos1, int pos2)
        {
            Node<T> tempNode = new Node<T>();
            tempNode.Element = this[pos1].Element;
            this[pos1].Element = this[pos2].Element;
            this[pos2].Element = tempNode.Element;
        }
        public void clear()
        {
            this.headNode = null;
            this.tailNode = null;
            this.Length = 0;
        }
        public string masToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Length; i++)
                sb.Append(this[i].Element + " ");
            return sb.ToString();
        }
    }

}
