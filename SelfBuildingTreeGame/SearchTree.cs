using System;
using System.Collections.Generic;
using System.Text;

namespace SelfBuildingTreeGame
{
    class SearchTree
    {
        public class Node
        {
            public string Data { get; set; }
            public string Answer { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(string data)
            {
                Data = data;
                Answer = null;
                Left = null;
                Right = null;
            }
        }

        public Node Root { get; set; }
        public bool Exit { get; set; }

        public Node Ask(Node node)
        {
            if (Exit == true)
            {
                return null;
            }
            if (node == null)
            {
                Console.WriteLine("You win.  What was your Animal?");
                String input = Console.ReadLine().ToLower();
                Node animal = new Node($"Is it a {input}");
                animal.Answer = input;
                Console.WriteLine("Enter a question that could have your animal as the answer.");
                String inputQ = Console.ReadLine();
                Node AnimalQuestion = new Node(inputQ);
                node = AnimalQuestion;
                node.Left = animal;
                return node;
            }
            else
            {

                Console.WriteLine(node.Data);
                string Uinput = Console.ReadLine().ToLower();
                if (Uinput == "y" || Uinput == "yes")
                {
                    if (node.Answer != null && node.Data.Contains(node.Answer))
                    {
                        Console.WriteLine("I win! Wanna Continue?");
                        string ToContinue = Console.ReadLine().ToLower();
                        if (ToContinue == "y" || ToContinue == "yes")
                        {
                            Ask(Root);
                        }
                        Exit = true;
                    }
                    if (node.Left == null)
                    {
                        node.Left = Ask(node.Left);
                        Ask(Root);
                    }
                    Ask(node.Left);
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = Ask(node.Right);
                        Ask(Root);
                    }
                    Ask(node.Right);
                }
            }

            return node;
        }
    }
}
