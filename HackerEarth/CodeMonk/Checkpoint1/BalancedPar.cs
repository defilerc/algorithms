using System;
using System.Linq;
using System.Collections.Generic;

public class BalancedPar
{
    public static void Main(string[] args)
    {
        var n = Console.ReadLine();
        var ar = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
        var array = new[] {0}.Concat(ar).ToArray();

        var result = 0;
        var stack = new Stack<int>();

        stack.Push(0);

        for (var i = 1; i <= ar.Length; i++) {
            if (array[i] > 0) {
                stack.Push(i);
                continue;
            }

            var index = stack.Pop();

            if (array[index] != -array[i]) {
                stack.Push(i);
                continue;
            }

            if (stack.Count == 0) {
                stack.Push(i);
                continue;
            }

            result = Math.Max(result, i - stack.Peek());
        }

        Console.WriteLine(result);
    }
}
