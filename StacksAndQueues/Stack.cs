using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class Stack
    {
        Node head;
        Node tail;
        int size;

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
                Console.WriteLine($"Head: {head.Data} Tail: {tail.Data}");
            }
            else
            {
                tail.Next = toAdd;
                toAdd.Prev = tail;
                tail = toAdd;
                Console.WriteLine($"Head: {head.Data} Tail: {tail.Data} TailPREV: {tail.Prev.Data}");
                Console.WriteLine($"Head NEXT: {head.Next.Data}");


            }
            size++;
            return toAdd.Data;
        }

        public object Pop()
        {
            if (head == null)
            {
                Console.WriteLine("The Queue is empty.");
                return null;
            }
            Node removed = tail;
            tail = removed.Prev;
            tail.Next = null;
            Console.WriteLine($"Head: {head.Data} Tail: {tail.Data}");
            size--;
            return removed.Data;
        }
    }
}
