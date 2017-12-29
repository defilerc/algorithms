namespace Algo
{
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ShortenedStringAlgo
    {
        public string shortenedString(string ss)
        {
            ss = Regex.Replace(ss, @"([A-Z])(\d+)",
                m => new StringBuilder().Insert(0, m.Groups[1].Value,
                    int.Parse(m.Groups[2].Value)).ToString());
            
            ss = Regex.Replace(ss, @"\(([A-Z\s]+)\)(\d+)",
                    m => new StringBuilder().Insert(0, m.Groups[1].Value,
                        int.Parse(m.Groups[2].Value)).ToString());

            return Regex.Match(ss, "[0-9]+").Success ? shortenedString(ss) : Regex.Replace(ss, @"\(|\)|\s", "");
        }

        string shortenedStringShort(string s) => s == (s = Regex.Replace(
                                                s, @" |([A-Z]|\((\w+)\))(\d+)", 
                                                m => string.Concat(
                                                    Enumerable.Repeat(
                                                        m.Groups[m.Groups[2] + s != s ? 2 : 1] + "",
                                                        int.Parse("0" + m.Groups[3])
                                                    )
                                                )
                                            ))
            ? s
            : shortenedString(s);
    }
}
