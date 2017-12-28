using System;
using Algo.Trees;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Tree<int>() {
                value = 1,
                left = new Tree<int>() {
                    value = 2,
                    left = new Tree<int>() {
                        value = 4,
                        right = new Tree<int>() {
                            value = 3
                        }
                    }
                },
                right = new Tree<int>() {
                    value = 5,
                    right = new Tree<int>() {
                        value = 6
                    }
                }
            };

            var algo = new Traversals();

            Console.Write("Inorder: ");
            algo.InOrder(t);

            Console.Write("Preorder: ");
            algo.PreOrder(t);

            Console.Write("Postorder: ");
            algo.PostOrder(t);

            Console.ReadLine();
        }
    }
}
