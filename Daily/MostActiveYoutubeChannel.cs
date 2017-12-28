
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace Daily
{
    public class MostActiveYoutubeChannelAlgo
    {
        public string mostActiveYoutubeChannel(string[] videoIDs)
        {
            var client = new System.Net.WebClient {
                BaseAddress = "https://www.googleapis.com"
            };

            var content = client.DownloadString(
                $"/youtube/v3/videos?id={string.Join(",", videoIDs)}&part=snippet&key=AIzaSyBGdoE9tvdgBX0jSeRGAZpegE_aHGO9NV8");

            var r = new Regex("\"channelTitle\": \"(.*)\"");
            //var m = r.Match(content);

            var max = 0;
//            var json = JObject.Parse(content);
            var channelHist = new SortedDictionary<string, int>(StringComparer.Ordinal);

            foreach (Match match in Regex.Matches(content, "\"channelTitle\": \"(.*)\"", RegexOptions.None)) {
                var title = match.Groups[1].Value;

                if (!channelHist.ContainsKey(title)) {
                    channelHist.Add(title, 0);
                }

                if (++channelHist[title] > max) {
                    max = channelHist[title];
                }
            }

            return channelHist.First(v => v.Value == max).Key;
        }
    }
}
