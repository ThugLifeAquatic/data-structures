using System;
using System.Collections.Generic;
using System.Text;

namespace TreeInorderPost
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

        //Incomplete Recursive add method(please ignore)

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

    }
}
