using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    using System;

    public class Solution
    {

        public static void Day5(String[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            Enumerable.Range(1, n).ToList().ForEach(i => Console.WriteLine($"{n} x {i} = {n * i}"));
        }

        public static void Day6(String[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i <= n; i++) {
                var s = Console.ReadLine();

                var s1 = new StringBuilder();
                var s2 = new StringBuilder();
                for (var j = 0; j < s.Length; j += 2) {
                    if (j % 2 == 0) {
                        s1.Append(s[j]);
                    }
                    else {
                        s2.Append(s[j]);
                    }
                }

                Console.WriteLine($"{s1} {s2}");
            }
        }

        public static void Day7(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var phones = new Dictionary<string, string>();

            for (var i = 0; i < n; i++) {
                var entry = Console.ReadLine().Split(' ');
                phones.Add(entry[0], entry[1]);
            }

            while (true) {
                var name = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(name)) {
                    break;
                }

                Console.WriteLine(phones.ContainsKey(name) ?
                    $"{name}={phones[name]}" : "Not found");
            }
        }
}

}