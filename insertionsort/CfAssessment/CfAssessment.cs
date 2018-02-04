using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo.CfAssessment
{
    public class CfAssessment
    {
        public string decodeString(string s)
        {
            var tokens = new Stack<string>();
            var nums = new Stack<int>();

            var num = new StringBuilder();
            var token = new StringBuilder();
            var output = new StringBuilder();

            for (var i = 0; i < s.Length; i++) {

                if ( (s[i] >= 'a' && s[i] <= 'z') || s[i] == '[' ) {

                    if (s[i] != '[') {
                        token.Append(s[i]);
                    }

                    if (num.Length > 0) {
                        nums.Push(int.Parse(num.ToString()));
                        num.Clear();
                    }

                } else if (s[i] >= '0' && s[i] <= '9') {
                    num.Append(s[i]);

                    if (token.Length > 0) {
                        tokens.Push(token.ToString());
                        token.Clear();
                    }
                } else if (s[i] == ']') {
                    tokens.Push(token.ToString());
                    token.Clear();

                    while (tokens.Count > 0) {
                        output.Append(string.Concat(Enumerable.Repeat(tokens.Pop(), nums.Pop())));
                    }
                }
            }

            return output.ToString();
        }

        public bool isLucky(int n)
        {
            var ns = n.ToString();
            var first = ns.Substring(0, ns.Length / 2);
            var second = ns.Substring(ns.Length / 2 + 1);

            return first.Sum(f => (int)f - 48) == second.Sum(s => (int) s - 48);
        }

        public string[] newNumeralSystem(char number)
        {
            var output = new List<string>();
            var ceil = Math.Ceiling( (double)(number - 65) / 2);
            var num = number - 65;
            
            for (var i = 0; i < ceil; i++) {
                output.Add((char) (65 + i) + " + " + (char) (65 + (num-i)));
            }

            return output.ToArray();
        }

    }
}
