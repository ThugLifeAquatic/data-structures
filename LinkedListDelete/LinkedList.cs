using System;
using System.Collections.Generic;
using System.Text;

namespace ReturnNthNode
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
            if (count % 2 != 0 && count > 2)
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
                Console.WriteLine($"Index {listIndex + 1} of {count}");
            }
        }

        public void PrintNth(int nth)
        {
            int listIndex = 0;
            int returnIndex = 0;
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = head;
                Node returnNode = head;
                while (current.Next != null)
                {
                    current = current.Next;
                    listIndex++;
                    if (listIndex >= nth)
                    {
                        returnNode = returnNode.Next;
                        returnIndex++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(returnNode.Data);
                Console.WriteLine($"Index {returnIndex + 1} of {count}");
            }
        }

        public void PrintNthData(string data)
        {
            int listIndex = 0;
            int returnIndex = 0;
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    if (current.Data == data)
                    {
                        returnIndex = listIndex;
                    }
                    current = current.Next;
                    listIndex++;
                }
                Console.WriteLine();
                Console.WriteLine($"{data} is at index {returnIndex + 1} of {count}");
            }
        }

        public void Delete(string data)
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = head;
                if (current.Data == data)
                {
                    head = current.Next;
                    current = null;
                    return;
                }
                while (current.Next != null)
                {
                    if (current.Next.Data == data)
                    {
                        Node temp = current.Next;
                        current.Next = null;
                        current.Next = temp.Next;
                        temp = null;
                    }
                    current = current.Next;
                }
                
            }
        }
    }
}
