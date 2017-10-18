using System;
using System.Collections.Generic;
using System.Text;

namespace BSTreeMinMax
{
    class SearchTree
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        public Node Root { get; set; }
        public void Add(Node node, int data)
        {
            if (Root == null)
            {
                Root = new Node(data);
                Console.WriteLine(Root.Data);
                return;
            }
            if (node.Data == data)
            {
                return;
            }
            if (data < node.Data)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(data);
                    Console.WriteLine(node.Left.Data);
                    return;
                }
                Add(node.Left, data);
            }
            if (data > node.Data)
            {
                if (node.Right == null)
                {
                    node.Right = new Node(data);
                    Console.WriteLine(node.Right.Data);
                    return;
                }
                Add(node.Right, data);
            }
        }

        public Node Min(Node node)
        {
            if(node == null)
            {
                return null;
            }
            if (node.Left == null)
            {
                return node;
            }
            return Min(node.Left);
        }

        public Node Max(Node node)
        {
            if (node == null)
            {
                return null;
            }
            if (node.Right == null)
            {
                return node;
            }
            return Max(node.Right);
        }

        public Node Find (Node node, int data)
        {
            if (node == null)
            {
                return null;
            }
            if (node.Data == data)
            {
                return node;
            }
            if (data < node.Data)
            {
                if (node.Left == null)
                {
                    return null;
                }
                return Find(node.Right, data);
            }
            else
            {
                if (node.Right == null)
                {
                    return null;
                }
                return Find(node.Right, data);
            }

        }

        //Incomplete, Disregard

        //public Node Remove(Node node, int data)
        //{
        //    if (node == null)
        //    {
        //        return null;
        //    }
        //    if (node.Data == data)
        //    {
        //        return node;
        //    }
        //    if (data < node.Data)
        //    {
        //        if (node.Left == null)
        //        {
        //            return null;
        //        }
        //        return Find(node.Right, data);
        //    }
        //    else
        //    {
        //        if (node.Right == null)
        //        {
        //            return null;
        //        }
        //        return Find(node.Right, data);
        //    }

        //}
    }
}
