using System.Collections.Generic;
using System.Linq;

namespace Daily
{
    public class ChatBot
    {
        public string[] chatBot(string[][] conversations, string[] currentConversation)
        {
            var matches = new List<ConvMatch>();

            foreach (var conversation in conversations) {

                var match = new ConvMatch {
                    Conversation = conversation,
                    Set = new HashSet<string>(conversation)
                };
                matches.Add(match);
            }

            foreach (var word in currentConversation) {
                foreach (var match in matches) {
                    if (!match.Set.Contains(word)) continue;

                    match.Matches++;
                }
            }

            var max = matches.Max(m => m.Matches);
            var convmatch = matches.FirstOrDefault(m => m.Matches > 0 && m.Matches == max);

            if (convmatch == null) {
                return currentConversation;
            }

            var curSet = new HashSet<string>(currentConversation);
            foreach (var word in currentConversation) {
                if (!convmatch.Set.Contains(word)) continue;

                var lastIndex = convmatch.Conversation
                    .ToList().FindLastIndex(curSet.Contains);

                if (lastIndex > convmatch.LastIndex) {
                    convmatch.LastIndex = lastIndex;
                }
            }

            return currentConversation.ToList()
                .Concat(convmatch.Conversation.Skip(convmatch.LastIndex + 1))
                .ToArray();
        }

        public class ConvMatch
        {
            public int Matches { get; set; }
            public int LastIndex { get; set; }
            public string[] Conversation { get; set; }
            public HashSet<string> Set { get; set; }
        }
    }
}
