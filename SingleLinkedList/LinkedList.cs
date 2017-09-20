using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedList
{
    class LinkedList
    {

        public Node head;

        public void Add(string data)
        {
            Node toAdd = new Node();
            toAdd.data = data;
            if (head == null)
            {
                toAdd.next = head;
                head = toAdd;
            }
            else
            {
                Node current = head;


                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = toAdd;
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
                Console.WriteLine(current.data);
                while (current.next != null)
                {
                    current = current.next;
                    Console.WriteLine(current.data);
                }
            }
        }

    }
}
