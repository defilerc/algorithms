using System;
using System.Linq;

namespace Daily.Jan
{
    public class PrivateEyesOnlyAlgo
    {
        public string privateEyesOnly(string message)
        {
            // E T A ...  Q J Z

            var chisquared = new decimal[26];

            for (var i = 0; i < 26; i++) {
                var alphabetsCount = message.Where(char.IsLetter).Select(x => (x + i) % 26 + (char.IsUpper(x) ? 65 : 97)).GroupBy(x => x)
                    .Select(x => new {
                        Character = x.Key,
                        Count = x.Count(),
                        Shift = i
                    })
                    //.OrderByDescending(c => c.Count)
                    .ToList();

                //chisquared[i] = sum (n * f_i' - n' * f_i)^2 / (n*n'*f_i);
            }

            var key = chisquared.Max(c => c);

            return new string(message.Select(c => (char) (c - key)).ToArray());
        }
    }
}
