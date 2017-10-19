using System;
using System.Collections.Generic;
using System.Text;

namespace TreeBreadth

{
    class Trees
    {
        public Node Root { get; set; }

        public object AddFirst(object data)
        {
            if (Root == null)
            {
                Root = new Node(data);
                return Root.Data;
            } else
            {
                Console.WriteLine("Tree already has a root");
                return null;
            }
        }

        public void Traverse(Node curr)
        {
            if (curr!= null)
            {
                Console.WriteLine(curr.Data);
                Traverse(curr.Left);
                Traverse(curr.Right);
            }
        }

        public void Inorder(Node curr)
        {
            if (curr != null)
            {
                Inorder(curr.Left);
                Console.WriteLine(curr.Data);
                Inorder(curr.Right);
            }
        }

        public void Postorder(Node curr)
        {
            if (curr != null)
            {
                Postorder(curr.Left);
                Postorder(curr.Right);
                Console.WriteLine(curr.Data);
            }
        }

        public void Breadth(Node curr)
        {
            Queue<Node> Q = new Queue<Node>();
            Q.Enqueue(curr);
            while (Q.Count > 0)
            {
                Node Traverse = Q.Dequeue();
                Console.WriteLine(Traverse.Data);
                if(Traverse.Left != null)
                {
                    Q.Enqueue(Traverse.Left);
                }
                if (Traverse.Right != null)
                {
                    Q.Enqueue(Traverse.Right);
                }
            }

        }

    }
}
