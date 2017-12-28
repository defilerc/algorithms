using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Daily;

namespace DailyTests
{
    [TestClass]
    public class MostActiveYoutubeChannelTests
    {
        [TestMethod]
        public void MostActiveYoutubeChannel()
        {
            var algo = new MostActiveYoutubeChannelAlgo();

            var result = algo.mostActiveYoutubeChannel(new[] {"Rd9ZKwNCYtM"});

            result = algo.mostActiveYoutubeChannel(new[] {"Rd9ZKwNCYtM", "YQJKgtAktLQ", "VL0eeXONpOs", "YaK8J0cxL8c", "JcAWr4gZgeI"});
        }
    }
}
