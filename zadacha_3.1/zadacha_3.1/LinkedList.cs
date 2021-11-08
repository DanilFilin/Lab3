using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_3._1
{
    class LinkedList<T> where T : IComparable
    {
        //Указатели на начальный и конечный элемент списка
        private LinkedListNode<T> _head;
        private LinkedListNode<T> _tail;
        private LinkedListNode<T> _now;

        //Текущее кол-во элементов в списке и метод для получения этого числа
        private int _count;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public LinkedListNode<T> now
        {
            get
            {
                return _now;
            }
        }

        //Создать элемент
        public void add(T value)
        {
            if (_head == null)
            {
                _head = _tail = _now = new LinkedListNode<T>(value, null);
                _count++;
            }
            else
            {
                AddAfter(_tail, value);
                _tail = _tail.Next;
                _now = _now.Next;
            }
        }

        //Создание элемента после нынешнего
        public void AddAfter(LinkedListNode<T> node, T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value, node.Next);
            node.Next = newNode;
            _count++;
        }

        //Удаление элемента
        public void removeAfter(LinkedListNode<T> node)
        {
            LinkedListNode<T> removedNode = node.Next;
            node.Next = removedNode.Next;
            removedNode.Next = null;
            if (removedNode == _tail)
            {
                _tail = node;
            }
            _count--;
        }

        //Удаление элемента при наличии у него указателя на следующий
        public void remove(LinkedListNode<T> node)
        {
            if (node.Next != null)
            {
                node.Value = node.Next.Value;
                removeAfter(node);
            }
            else
            {
                removeAfter(findPrevNode(node));
            }
        }

        public LinkedListNode<T> findPrevNode(LinkedListNode<T> node)
        {
            LinkedListNode<T> prevNode = null;
            LinkedListNode<T> currNode = _head;
            while (currNode != null)
            {
                prevNode = currNode;
                currNode = currNode.Next;
            }
            return prevNode;
        }

        //Показать весь список
        public void showAll()
        {
            _now = _head;
            for (int i = 0; i < _count; i++)
            {                
                Console.WriteLine(_now.Value);
                _now = _now.Next;
            }
        }

        //Найти элемент
        public LinkedListNode<T> find(T value)
        {
            LinkedListNode<T> ptr = _head;
            while (ptr != null)
            {
                if (ptr.Value.CompareTo(value) == 0)
                {
                    _now = ptr;
                    return ptr;
                }
                    
                ptr = ptr.Next;
            }

            return null;
        }

        //Показать элемент
        public void showNode(LinkedListNode<T> node)
        {
            Console.WriteLine(_now.Value);
        }
    }
}
