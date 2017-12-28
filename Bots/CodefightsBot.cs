using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Bots
{
    public class CodefightsBot
    {
        public double companyBotStrategy(int[][] trainingData)
        {
            var time = 0d;
            var count = 0;
            foreach (var t in trainingData) {
                if (t[1] == 1) {
                    time += t[0];
                    count++;
                }
            }

            return time / count;
        }

        public string[] taskMaker(string[] source, int challengeId)
        {
            var debug = new Dictionary<int, Tuple<string, int>>();
            var clean = new List<string>();
            var replaceLine = -1;
            foreach (var line in source) {
                var match = Regex.Match(line, "(\\s*)//DB (\\d+)//(.*)");

                if (match.Success) {
                    debug.Add(int.Parse(match.Groups[2].Value), 
                        new Tuple<string, int>(match.Groups[1].Value + match.Groups[3].Value, replaceLine));
                    clean.Add("");
                } else {
                    clean.Add(line);
                    replaceLine++;
                }
            }

            clean[debug[challengeId].Item2] = debug[challengeId].Item1;
            return clean.Where(c => c != "").ToArray();
        }

        public bool plagiarismCheck(string[] code1, string[] code2)
        {
            if (code1.Length != code2.Length) {
                return false;
            }

            var plagi = new Dictionary<string, string>();
            var mapping = new Dictionary<string, string>();

            for (var i = 0; i < code1.Length; i++) {
                if (code1[i] == code2[i]) {
                    continue;
                }

                var token1 = code1[i].Split(new[] {' ', '.', '?', ')', '(', ','}, StringSplitOptions.RemoveEmptyEntries);
                var token2 = code2[i].Split(new[] {' ', '.', '?', ')', '(', ','}, StringSplitOptions.RemoveEmptyEntries);

                if (token1.Length != token2.Length) {
                    return false;
                }

                for (var j = 0; j < token1.Length; j++) {

                    if (!mapping.ContainsKey(token1[j])) {
                        mapping.Add(token1[j], token2[j]);
                    } else if (mapping[token1[j]] != token2[j]) {
                        return false;
                    }

                    if (token1[j] == token2[j]) {
                        continue;
                    }

                    var m1 = Regex.Match(token1[j], "^[a-zA-Z_][a-zA-Z_0-9]*$");
                    var m2 = Regex.Match(token2[j], "^[a-zA-Z_][a-zA-Z_0-9]*$");
                    
                    if (!m1.Success || !m2.Success) {
                        return false;
                    }

                    if (!plagi.ContainsKey(token1[j])) {
                        plagi.Add(token1[j], token2[j]);
                        continue;
                    }

                    if (token2[j] != plagi[token1[j]]) {
                        return false;
                    }
                }
            }

            return mapping.Any(m => m.Key != m.Value);
        }
    }
}
