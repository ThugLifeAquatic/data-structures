using System;
using System.Collections.Generic;
using System.Text;

namespace TwoStacks
{
    class QueueStack
    {
        Stack stack1 = new Stack();
         Stack stack2 = new Stack();
 
         public object Enqueue(object data)
         {
             stack1.Push(data);
             return data;
         }

        public object Dequeue()
        {
            while (stack1.NotEmpty())
            {
                stack2.Push(stack1.Pop());
            }

            var returnThis = stack2.Pop();

            while (stack2.NotEmpty())
            {
                stack1.Push(stack2.Pop());
            }
            Console.WriteLine($"Returns {returnThis} ");
            return returnThis;
        }
    }
}
