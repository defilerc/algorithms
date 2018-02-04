using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Daily
{
    public class VigenereKeyAlgo
    {
        public string vigenereKey(string original, string cipher)
        {
            var key = string.Concat(cipher.Select((c, i) => {
                return (char) (c - original[i] >= 0 ? c - original[i] + 97 : 123 + c - original[i]);
            }));
            var shortest = Regex.Match(key, $"^(\\w+?)\\1(\\w+)");

            return shortest.Success && key.StartsWith(shortest.Groups[2].Value) ? shortest.Groups[1].Value : key;
        }

        public string vigenereKeyShort(string o, string c)
        {
            var k = string.Concat(c.Select((x, i) => (char) (x - o[i] >= 0 ? x - o[i] + 97 : 123 + x - o[i])));
            var s = Regex.Match(k, @"^(\w+?)\1(\w+)");

            return s.Success && k.StartsWith(s.Groups[2].Value) ? s.Groups[1].Value : k;
        }
    }
}
