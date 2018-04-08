using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo.Trees
{
    public class FindSubstrings
    {
        public string[] findSubstrings(string[] words, string[] parts)
        {
            var trie = new Trie();

            foreach (var part in parts) {
                trie.Insert(part);
            }

            var output = new List<StringBuilder>();
            foreach (var w in words) {
                var word = new StringBuilder(w);
                var match = FindSubstr(w, trie);

                if (match.Item1 >= 0) { 
                    word.Insert(match.Item1, "[");
                    word.Insert(match.Item1 + match.Item2 + 1, "]");
                }

                output.Add(word);
            }

            return output.Select(o => o.ToString()).ToArray();
        }

        private Tuple<int, int> FindSubstr(string str, Trie trie)
        {
            var matchIndex = -1;
            var matchLength = 0;

            for (var start = 0; start < str.Length; start++) {
                var curNode = trie;

                for (var pos = start; pos < str.Length; pos++) {
                    if (!curNode.Nodes.ContainsKey(str[pos])) {
                        break;
                    }

                    curNode = curNode.Nodes[str[pos]];
                    var length = pos - start + 1;
                    
                    if (curNode.Terminal && length > matchLength) {
                        matchIndex = start;
                        matchLength = length;
                    }
                }
            }

            return new Tuple<int, int>(matchIndex, matchLength);
        }

        public class Trie
        {
            public Dictionary<char, Trie> Nodes { get; set; }

            public int Match { get; set; }

            public bool Terminal { get; set; }

            public Trie()
            {
                Nodes = new Dictionary<char, Trie>();
            }

            public void Insert(string str)
            {
                if (string.IsNullOrWhiteSpace(str)) {
                    return;
                }

                var curNode = this;
                
                for (var i = 0; i < str.Length; i++) {
                    if (!curNode.Nodes.ContainsKey(str[i])) {
                        curNode.Nodes.Add(str[i], new Trie());
                    }
                    curNode = curNode.Nodes[str[i]];
                }

                curNode.Terminal = true;
            }

            public override string ToString()
            {
                if (Nodes == null) {
                    return "";
                }

                return string.Join(", ", Nodes.Keys.Select(k => k.ToString()));
            }
        }
    }
}
