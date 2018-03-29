namespace HackerRank
{
    using System;
    using System.Collections.Generic;

    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
    class Solution
    {
        static int getHeight(Node root)
        {
            //Write your code here
            var maxHeight = 1;

            var queue = new Stack<Node>();
            var height = new Stack<int>();
            queue.Push(root);
            height.Push(1);

            while (queue.Count > 0) {
                var node = queue.Pop();
                var cur = height.Pop();

                maxHeight = Math.Max(maxHeight, cur);

                if (node.left != null) {
                    queue.Push(node.left);
                    height.Push(cur + 1);
                }

                if (node.right != null) {
                    queue.Push(node.right);
                    height.Push(cur + 1);
                }
            }

            return maxHeight;
        }

        static Node insert(Node root, int data)
        {
            if (root == null) {
                return new Node(data);
            } else {
                Node cur;
                if (data <= root.data) {
                    cur = insert(root.left, data);
                    root.left = cur;
                } else {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0) {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);

        }
    }
}
