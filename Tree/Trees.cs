using System;
using System.Collections.Generic;
using System.Text;

namespace TwoLevelTree
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

        //public object Add(Node cur, object data)
        //{
        //    if (cur.Left == null)
        //    {
        //        cur.Left = new Node(data);
        //        return data;
        //    }
        //    else if (cur.Right == null)
        //    {
        //        cur.Right = new Node(data);
        //        return data;
        //    }
        //    else
        //    {

        //    }
        //}

    }
}
