using System.Collections.Generic;

namespace Algo.Strings
{
    public class TextJustificationAlgo
    {
        public string[] textJustification(string[] words, int l)
        {
            var line = new List<string>();
            var output = new List<string>();

            var lineWordsLength = 0;

            for (var i = 0; i < words.Length; i++) {

                if (lineWordsLength + words[i].Length + (line.Count - 1) > l) {

                    var formattedLine = FormatLine(line, lineWordsLength, l);
                    output.Add(formattedLine);

                    line = new List<string>();
                    lineWordsLength = 0;
                }

                line.Add(words[i]);
                lineWordsLength += words[i].Length;
            }

            output.Add(string.Join(" ", line).PadRight(l));
            return output.ToArray();
        }

        private string FormatLine(List<string> line, int lineWordsLength, int l)
        {
            var left = l - lineWordsLength;

            if (left == 0) {
                return string.Join(" ", line);
            }

            var numSpaces = left / (line.Count - 1);

            for (var j = 0; j < left % (line.Count - 1); j++) {
                line[j] = line[j] + " ";
            }

            return string.Join(new string(' ', numSpaces), line);
        }
    }
}
