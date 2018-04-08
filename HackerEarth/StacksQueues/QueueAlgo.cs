namespace HackerEarth.StacksQueues
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class QueueAlgo
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var q = new Queue<string>();

            while (n-- > 0) {
                var f = Console.ReadLine().Split(' ').ToArray();

                if (f.Length == 1) {
                    Console.WriteLine(q.Count > 0 ? $"{q.Dequeue()} {q.Count}" : $"-1 {q.Count}");
                }
                else {
                    q.Enqueue(f[1]);
                    Console.WriteLine(q.Count);
                }
            }
        }
    }
}
