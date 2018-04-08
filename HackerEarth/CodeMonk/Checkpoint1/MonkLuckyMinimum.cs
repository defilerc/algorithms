using System;
using System.Linq;

public class Solution {

    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());

        while (t-- > 0) {
            var n = Console.ReadLine();
            var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(a);

            var min = a[0];
            var count = 0;

            for (var i = 1; i < a.Length; i++) {
                if (a[i] == min) {
                    count++;
                } else {
                    break;
                }
            }

            Console.WriteLine(count % 2 == 0 ? "Lucky" : "Unlucky");
        }
    }
}
