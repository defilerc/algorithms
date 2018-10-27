using System.Collections.Generic;

namespace Algo.TopTal2
{
    public class Solution2
    {
        public int solution(int N)
        {
            var s = N.ToString();
            var set = new HashSet<string>();
            

            for (var i = 0; i < s.Length; i++) {

                if (s[i] == '0') {
                    continue;
                }

                var str = s[i].ToString();

                PickDigit(s.Remove(i, 1), set, str);
            }

            return set.Count;
        }

        private string PickDigit(string s, HashSet<string> set, string str)
        {
            if (string.IsNullOrWhiteSpace(s)) {
                set.Add(str);
                return "";
            }

            for (var j = 0; j < s.Length; j++) {
                str += s[j].ToString();
                //return PickDigit(s.Remove(j, 1), set, str);
            }

            return "";
        }

        //public class Trie
        //{
        //    public char[] c;
        //    public Tree l;
        //    public Tree r;
        //};
    }
}
