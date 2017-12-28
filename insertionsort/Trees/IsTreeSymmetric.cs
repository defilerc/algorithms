using System;
using System.Collections.Generic;
using Algo;

namespace AlgoTests.Trees
{
    public class IsTreeSymmetric
    {
        public bool isTreeSymmetric(Tree<int> t) {
    
            var queue = new Queue<int>();
    
            EnqueueLeft(t.left, queue);
            DequeueRight(t.right, queue);

            return (queue.Count == 0);
        }

        void EnqueueLeft(Tree<int> t, Queue<int> q) 
        {
            q.Enqueue(t?.value ?? Int32.MinValue);
            
            if (t == null) {
                return;
            }
    
            EnqueueLeft(t.left, q);
            EnqueueLeft(t.right, q);
        }

        void DequeueRight(Tree<int> t, Queue<int> q)
        {
            var value = q.Peek();

            if (value != (t?.value ?? Int32.MinValue)) {
                return;
            }

            if (t == null) {
                return;
            }

            q.Dequeue();
    
            DequeueRight(t.right, q);
            DequeueRight(t.left, q);
        }
    }
}
