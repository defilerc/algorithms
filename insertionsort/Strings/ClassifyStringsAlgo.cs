using System.Linq;

namespace Algo.Strings
{
    public class ClassifyStringsAlgo
    {
        public string classifyStrings(string s)
        {
            return Classify(s, 0, 0, 0);
        }

        // true: good, false: bad
        public string Classify(string s, int pos, int vowels, int consonants)
        {
            if (vowels >= 3) {
                return "bad";
            }

            if (consonants >= 5) {
                return "bad";
            }

            if (pos >= s.Length) {
                return "good";
            }

            var vowelsList = new[] {'a', 'e', 'i', 'o', 'u'};

            if (s[pos] == '?') {
                var chooseVowel = Classify(s, pos + 1, vowels + 1, 0);
                var chooseConsonant = Classify(s, pos + 1, 0, consonants + 1);

                if (chooseVowel == "bad" && chooseConsonant == "bad") {
                    return "bad";
                } 
                if (chooseVowel == "good" && chooseConsonant == "good") {
                    return "good";
                } 
                return "mixed";
            }

            return vowelsList.Contains(s[pos]) 
                ? Classify(s, pos + 1, vowels + 1, 0) 
                : Classify(s, pos + 1, 0, consonants + 1);
        }
    }
}