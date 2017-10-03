using System;
using System.Collections.Generic;
using System.Text;

namespace TwoLevelTree
{
    class Node
    {
        public object Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node (object data)
        {
            Data = data;
            Console.WriteLine($"Node {data}");
        }
    }
}
