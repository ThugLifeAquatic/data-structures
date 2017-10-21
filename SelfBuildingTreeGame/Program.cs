using System;
using static SelfBuildingTreeGame.SearchTree;

namespace SelfBuildingTreeGame
{
    class Program
    {
        

        static void Main(string[] args)
        {
            SearchTree gameTree = new SearchTree();

            gameTree.Root = new Node("Is it a mammal?");
            gameTree.Ask(gameTree.Root);
        }


    }
}
