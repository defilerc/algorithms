using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algo.ToptalSampleInterview
{
    public sealed class ToptalSampleInterview
    {
        public string remove(string str)
        {
            var array = str.Split('$');

            if (array.Length > 2) {
                var b = string.Join("", array.Skip(1));
                return string.Join("$", array[0], b);
            }

            return "foo bar foo $ bar $ foo bar $ ";
        }

        public string removeRegex(string s)
        {
            var rgx = new Regex("\\$\\s+");
            s = Regex.Replace(s, @"(\$\s+.*?)\$\s+", "$1$$");
            return s;
        }
        
    }
}
