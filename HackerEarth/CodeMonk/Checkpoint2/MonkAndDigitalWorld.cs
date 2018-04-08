namespace HackerEarth.CodeMonk.Checkpoint2
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class MonkAndDigitalWorld
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            var dic1 = new Dictionary<char, int>();
            var dic2 = new Dictionary<char, int>();

            for (var i = 0; i < n ; i++) {
                if (dic1.ContainsKey(str1[i])) {
                    dic1[str1[i]]++;
                } else {
                    dic1.Add(str1[i], 1);
                }

                if (dic2.ContainsKey(str2[i])) {
                    dic2[str2[i]]++;
                } else {
                    dic2.Add(str2[i], 1);
                }
            }

            var canBeSwapped = dic1.Keys.Count == dic2.Keys.Count && 
                dic1.Keys.All(k => dic2.Keys.Contains(k) && dic2[k] == dic1[k]);

            Console.WriteLine(canBeSwapped ? "YES" : "NO");
        }
    }
}
