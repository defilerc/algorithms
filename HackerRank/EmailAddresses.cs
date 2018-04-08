namespace HackerRank
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class EmailAddresses
    {
        public static void Main(String[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var matches = new List<string>();

            for (int i = 0; i < n; i++) {
                var tokens = Console.ReadLine().Split(' ');
                var first = tokens[0];
                var email = tokens[1];

                if (Regex.IsMatch(email, $"{first}@gmail.com")) {
                    matches.Add(first);
                };
            }

            Console.WriteLine(string.Join("\n", matches.OrderBy(m => m)));
        }
    }
}
