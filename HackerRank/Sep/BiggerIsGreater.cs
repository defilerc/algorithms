using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Sep
{
    public class BiggerIsGreaterAlgo
    {
        private static string BiggerIsGreater(string w)
        {
            string greatest = string.Concat(w.OrderByDescending(x => x));

            if (w == greatest) {
                return "no answer";
            }

            StringBuilder higher = new StringBuilder(w);

            for (int j = w.Length - 1; j >= 1; j--) {
                for (int i = w.Length - 2; i >= 0; i--) {
                    if (w[i] < w[j]) {
                        //(higher[i], higher[w.Length - 1]) = (higher[w.Length - 1], higher[i]);
                        char tmp = higher[i];
                        higher[i] = higher[j];
                        higher[j] = tmp;

                        return higher.ToString();
                    }
                }
            }

            return "no answer";
        }

        public string[] Perms(string w)
        {
            var perms = new List<string>();

            for (int i = 0; i < w.Length; i++) {
                perms.AddRange(Take(w, i));
            }

            return perms.ToArray();
        }

        private string[] Take(string w, int i)
        {
            var list = new List<char>(w);
            list.RemoveAt(i);

            var perms = new List<string>();

            for (int j = 0; j < list.Count; j++) {
                perms.Add(string.Concat(w[i], string.Join("", Take(string.Join("", list), j))));
            }

            return perms.ToArray();
        }
    }
}
