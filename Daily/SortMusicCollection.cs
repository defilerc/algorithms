using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Daily
{
    public class SortMusicCollection
    {
        public string[] sortMusicCollection(string[] a)
        {
            var ao = new List<A>();
            var cl = new System.Net.WebClient {
                BaseAddress = "https://api.discogs.com",
            };

            foreach (var i in a) {
                var at = i.Split(',');
                cl.Headers.Add("User-Agent", "cf");
                var c = cl.DownloadString(
                    "/database/search?artist={at[0]}&release_title={at[1]}&country=us&type=release&key=sOVaYNuiGRsgCHYTCWFe&secret=IpqmkTQFYJQNbaWKdVJPoipTgdCfWDjG");
                var m = Regex.Matches(c, "\"year\": \"(\\d+)\"");

                var y = int.MaxValue;
                foreach (Match t in m) {
                    var n = int.Parse(t.Groups[1].Value);
                    if (n < y) { y = n; }
                }

                ao.Add(new A { B = at[0], T = at[1], Y = y });
            }

            return ao
                .OrderBy(x => x.Y)
                .ThenBy(x => x.B, StringComparer.Ordinal)
                .ThenBy(x => x.T)
                .Select(x => string.Join(",", x.B, x.T))
                .ToArray();
        }

        public class A { public string T; public string B; public int Y; }
    }
}
