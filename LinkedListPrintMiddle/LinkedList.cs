using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPrintMiddle
{
    class LinkedList
    {


        public Node head;
        int count = 0;
        int mid = 0;

        public void Add(string data)
        {
            Node toAdd = new Node(data);
            if (head == null)
            {
                toAdd.Next = head;
                head = toAdd;
            }
            else
            {
                Node current = head;


                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = toAdd;
            }
            count++;
            if (count % 2 != 0 && count > 2 )
            {
                mid++;
            }
        }
        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = head;
                Console.WriteLine(current.Data);
                while (current.Next != null)
                {
                    current = current.Next;
                    Console.WriteLine(current.Data);
                }
            }
        }

        public void PrintMiddle()
        {
            int listIndex = 0;
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = head;
                while (listIndex < mid)
                {
                    current = current.Next;
                    listIndex++;
                }
                Console.WriteLine();
                Console.WriteLine(current.Data);
                Console.WriteLine($"Index {listIndex+1} of {count}");
            }
        }


    }
}
