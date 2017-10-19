using System;
using System.Collections.Generic;
using System.Text;

namespace BSTreeRemove
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

        public Node FindParent (Node node, int data)
        {
            if (node == null)
            {
                return null;
            }
            if (data < node.Data && node.Left != null)
            {
                if (node.Left.Data == data)
                {
                    return node;
                }
                return FindParent(node.Left, data);
            }
            else if (data > node.Data && node.Right != null)
            {
                if (node.Right.Data == data)
                {
                    return node;
                }
                return FindParent(node.Right, data);
            }
            else
            {
                return new Node(0);
            }

        }

        //Incomplete, Disregard

        public Node Remove(Node node, int data)
        {
            Node Target;
            Node Temp;
            Node Swap;
            Node Parent = FindParent(Root, data);
            if (Parent.Left == null && Parent.Right == null)
            {
                return null;
            }
            if (Parent.Left != null && Parent.Left.Data == data)
            {
                Target = Parent.Left;
                if (Target.Left == null)
                {
                    if (Target.Right == null)
                    {
                        Parent.Left = null;
                        return Target;
                    }
                    Parent.Left = Target.Right;
                }
                Swap = Max(Target.Left);
                Temp = FindParent(Target.Left, Swap.Data);
                if (Swap.Left != null)
                {
                    Temp.Right = Swap.Left;
                    Swap.Left = null;
                }
                Target.Data = Swap.Data;
                Swap.Data = data;
                return Swap;
            }
            else
            {
                Target = Parent.Right;
                if (Target.Left == null)
                {
                    if (Target.Right == null)
                    {
                        Parent.Left = null;
                        return Target;
                    }
                    Parent.Left = Target.Right;
                }
                Swap = Max(Target.Left);
                Temp = FindParent(Target.Left, Swap.Data);
                if (Swap.Left != null)
                {
                    Temp.Right = Swap.Left;
                    Swap.Left = null;
                }
                Target.Data = Swap.Data;
                Swap.Data = data;
                return Swap;
            }
           


        }
    }
}
