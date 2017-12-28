using System;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class ChatBotTests
    {
        [TestMethod]
        public void ChatBot()
        {
            var algo = new ChatBot();
            var result = algo.chatBot(new string[][] {
                    new[] {"where", "are", "you", "live", "i", "live", "in", "new", "york"},
                    new[] {"are", "you", "going", "somewhere", "tonight", "no", "i", "am", "too", "tired", "today"},
                    new[] {"hello", "what", "is", "your", "name", "my", "name", "is", "john"}
                },
                new[] {
                    "hello", "john", "do", "you", "have", "a", "favorite", "city", "to", "live", "in", "yes", "it",
                    "is"
                });

            result = algo.chatBot(new string[][] {
                    new[] {"lets", "have", "some", "fun"},
                    new[] {"i", "never", "get", "it"},
                    new[] {"be", "aware", "of", "this", "house"},
                    new[] {"he", "will", "call", "her"}
                },
                new[] {"can", "you", "please"});
        }
    }
}
