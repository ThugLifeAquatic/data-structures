using System;
using System.Collections.Generic;
using System.Text;

namespace TwoStacks
{
    class Stack
    {
        public Node head;
        public Node tail;
        public int size;

        public object Push(object data)
        {
            Node toAdd = new Node
            {
                Data = data
            };

            if (head == null)
            {
                head = toAdd;
                tail = head;
                Console.WriteLine($"Head: {head.Data}  Tail: {tail.Data}");
            }
            else
            {
                tail.Next = toAdd;
                toAdd.Prev = tail;
                tail = toAdd;
                Console.WriteLine($"Pushing: {tail.Data}");
            }
            size++;
            return toAdd.Data;

        }

        public object Pop()
        {
            if (head == null)
            {
                Console.WriteLine("The Stack is empty.");
                return null;
            }

            Node removed = tail;

            if (tail.Prev == null)
            {
                head = null;
                return removed.Data;
            }

            tail = removed.Prev;
            tail.Next = null;

            Console.WriteLine($"Popped: {removed.Data}");
            size--;
            return removed.Data;
        }

        public bool NotEmpty()
        {
            if (head != null)
            {
                return true;
            }
            return false;
        }

    }
}
