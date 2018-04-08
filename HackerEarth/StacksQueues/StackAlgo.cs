namespace HackerEarth.StacksQueues
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StackAlgo
    {
        public static void Main(string[] args)
        {
            var q = int.Parse(Console.ReadLine());
            var s = new Stack<int>();

            while (q-- > 0) {
                var f = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (f.Count() == 1) {
                    Console.WriteLine(s.Count > 0 ? $"{s.Pop()}" : "No Food");
                }
                else {
                    s.Push(f[1]);
                }
            }
        }
    }
}
