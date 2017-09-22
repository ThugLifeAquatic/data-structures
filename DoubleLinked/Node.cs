using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinked
{
    class Node
    {
        public Node Previous;
        public Node Next;
        public Object Data;

        public Node(Object data) => Data = data;
    }
}
