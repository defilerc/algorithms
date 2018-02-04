using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Daily.Jan
{
    public class DonkeyKongCountryAlgo
    {
        public string donkeyKongCountry(string[] s)
        {
            var r = Regex.Match(s[0].Replace("-", "_"), 
                @"([0-9A-Z]{4}) = ([\w\s]+)[^\w]?"
                );
            var words = r.Groups[2].Value;
            var last = words.Trim().Split(' ').Last().ToLower();

            var d = new List<string>();
            
            foreach (var s1 in s) {
                r = Regex.Match(s1, @"^([0-9A-Z]{4})");
                var hex = r.Groups[1].Value;
                d.Add($"0x{hex}");
            }

            return $"Int32[] {last}=new Int32[] {{{string.Join(",", d)}}}";
        }

        public string donkeyKongCountryShort(string[] s)
        {
            var r = Regex.Match(s[0].Replace("-", "_"),
                @"([0-9A-Z]{4}) = ([\w\s]+)[^\w]?"
            );
            
            var l = r.Groups[2].Value.Trim().Split(' ').Last().ToLower();
            var d = new List<string>();

            s.ToList().ForEach(x => {
                r = Regex.Match(x, @"^([0-9A-Z]{4})");
                d.Add($"0x{r.Groups[1].Value}");
            });

            return $"Int32[] {l}=new Int32[] {{{string.Join(",", d)}}}";
        }

        public string donkeyKongCountryShort2(string[] s)
        {
            var d = new List<string>();
            var l = "";
            s.ToList().ForEach(x => {
                var r = Regex.Match(x = x.Replace("-", "_"),
                    @"^([0-9A-Z]{4}) = ([\w\s]+)[^\w]?"
                );

                d.Add($"0x{r.Groups[1].Value}");
                l = r.Groups[2].Value.Trim().Split(' ').Last().ToLower();
            });

            return $"Int32[] {l}=new Int32[] {{{string.Join(",", d)}}}";
        }

        public string donkeyKongCountryShort3(string[] s)
        {
            var d = new List<string>();
            var l = "";
            s.ToList().ForEach(x => {
                var r = Regex.Match(x.Replace("-", "_"),
                    @"([0-9A-Z]{4}) = [\w\s]+\b(\w+(?!\w\s))[^\w]?"
                );

                d.Add($"0x{r.Groups[1].Value}");
                l = r.Groups[2].Value.ToLower();
            });

            return $"Int32[] {l}=new Int32[] {{{string.Join(",", d)}}}";
        }
        

    }
}
