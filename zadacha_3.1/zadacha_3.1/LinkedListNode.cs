using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_3._1
{
    class LinkedListNode<T>
    {
        //Значение, хранящееся в узле списка
        public T Value;
        //След. элемент
        public LinkedListNode<T> Next;

        public LinkedListNode(T value, LinkedListNode<T> next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
