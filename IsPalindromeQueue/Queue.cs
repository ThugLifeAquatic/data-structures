using System;
using System.Collections.Generic;
using System.Text;

namespace IsPalindromeQueue
{
    class Queue
    {
        Node head;
        Node tail;
        int size;

        public object Enqueue(object data)
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
                tail = toAdd;
                Console.WriteLine($"Head: {head.Data} Tail: {tail.Data}");
                Console.WriteLine($"Head NEXT: {head.Next.Data}");


            }
            size++;
            return toAdd.Data;
        }

        public object Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("The Queue is empty.");
                return null;
            }
            Node removed = head;
            head = removed.Next;
            if (head != null)
            {
            Console.WriteLine($"Head: {head.Data} Tail: {tail.Data}");
            }
            size--;
            return removed.Data;
        }

     



    }
}
