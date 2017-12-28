using System.Text;

namespace Algo.Strings
{
    public class AmendTheSentence
    {
        public string amendTheSentence(string s)
        {
            var solution = new StringBuilder(s);

            for (var i = 0; i < s.Length; i++) {
                solution.Append(s[i] <= 'Z' ? new[] {' ', char.ToLower(s[i]) } : new[] {s[i]});
            }

            return solution.ToString().Trim();
        }
    }
}
