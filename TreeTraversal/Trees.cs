using System;
using System.Collections.Generic;
using System.Text;

namespace TreeTraversal
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
                Traverse(curr.Left);
                Console.WriteLine(curr.Data);
                Traverse(curr.Right);
            }
        }

    }
}
