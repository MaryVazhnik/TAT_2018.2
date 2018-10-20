using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1
{
    public class Stack : Node
    {
        public int Count { get; set; }
        public void Push(int value)
        {
            Node node = new Node { Size = value };
            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
            Count++;
        }
        public int Pop()
        {
            if (Count < 1)
                throw new Exception("Stack is empty!");
            if (Count == 1)
            {
                Count = 0;
                int t = _head.Size;
                _head = _tail = null;
                return t;
            }
            Node element = _head;
            while (element.Next != _tail)
            {
                element = element.Next;
            }
            int tempItem = element.Next.Size;
            _tail = element;
            Count--;
            return tempItem;
        }

    }
}