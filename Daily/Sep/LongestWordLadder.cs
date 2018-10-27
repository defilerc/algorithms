using System;
using System.Collections.Generic;
using System.Linq;

namespace Daily.Sep
{
    public class LongestWordLadder
    {
        public string[] longestWordLadder(string startWord, string goalWord, string[] usableWords)
        {

            var stack = new Stack<string>();
            stack.Push(startWord);

            var list = new List<string>(usableWords);
            list.Add(goalWord);
            var dict = new Dictionary<string, int>();
            var step = 1;

            while (stack.Count > 0) { 
                foreach (var word in list) {
                    var count = 0;
                    var skip = false;

                    for (var i = 0; i < word.Length; i++) {
                        if (word[i] != startWord[i]) {
                            count++;
                        }
                        if (count > 1) {
                            skip = true;
                        }
                    }

                    if (skip) continue;

                    if (!dict.ContainsKey(word)) {
                        dict[word] = 1;
                    } else {
                        dict[word]++;
                    }

                    if (dict[word] <= step) {
                        stack.Push(word);
                    }

                    
                }
            }

            return new string[] { "" };
        }

        //private string[] DoWork(string word, string startWord, string goalWord, bool v)
        //{
        //    if (word == goalWord) {

        //    }
            

        //}
    }
}
