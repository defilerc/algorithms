using System.Linq;

namespace Algo.HeapStackQueue
{
    public class DecodeString
    {
        public string decodeString(string s)
        {
            return Tokenize(s, 0);
        }

        private string Tokenize(string s, int index)
        {
            if (index >= s.Length) {
                return "";
            }

            if (char.IsLetter(s[index])) {
                return s[index] + Tokenize(s, index + 1);
            }

            var mult = "";
            var start = index;
            while (char.IsDigit(s[start])) {
                mult += s[start];
                start++;
            }
            var multint = int.Parse(mult);

            var bracketCount = 1;
            var end = start + 1;

            while (bracketCount > 0) {
                if (s[end] == '[') {
                    bracketCount++;
                }

                if (s[end] == ']') {
                    bracketCount--;
                }

                end++;
            }

            return Multiply(multint, Tokenize(s.Substring(start + 1, end - start - 2), 0)) + Tokenize(s, end);
        }

        public string Multiply(int mult, string s)
        { 
            return string.Concat(Enumerable.Repeat(s, mult));
        }
    }
}
