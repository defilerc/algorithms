using System.Text;

namespace Algo.TopTal2
{
    public class Round2Prob2
    {
        public string Capitalize(string s)
        {
            if (s.Length == 0) {
                return s;
            }

            var str = new StringBuilder(s);

            return CapitalizeStr(str, 0, false).ToString();

        }

        private StringBuilder CapitalizeStr(StringBuilder str, int i, bool prevIsPunc)
        {
            if (i >= str.Length) {
                return str;
            }

            if (i == 0 && str[i] >= 'a' && str[i] <= 'z') {
                str[i] = char.ToUpper(str[i]);

                return CapitalizeStr(str, i + 1, false);
            }

            var curIsPunc = str[i] == '.' || str[i] == '?' || str[i] == '!';

            if (curIsPunc && prevIsPunc) {
                return CapitalizeStr(str, i + 1, true);
            }

            if (prevIsPunc && str[i] != ' ' && str[i - 1] != ' ') {
                str.Insert(i, ' ');
                return CapitalizeStr(str, i + 1, true);
            }

            if (prevIsPunc && str[i] == ' ' && str[i - 1] == ' ') {
                str.Remove(i, ' ');
                return CapitalizeStr(str, i + 1, true);
            }

            if (prevIsPunc && str[i] >= 'a' && str[i] <= 'z') {
                str[i] = char.ToUpper(str[i]);

                return CapitalizeStr(str, i + 1, false);
            }

            return CapitalizeStr(str, i + 1, curIsPunc);
        }
    }
}
