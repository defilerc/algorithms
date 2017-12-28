using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class SortMusicCollectionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new SortMusicCollection();
            var result = algo.sortMusicCollection(new[] {
                "The Beatles,Please Please Me",
                "Bob Marley and the Wailers,Natty Dread",
                "Pink Floyd,The Dark Side of the Moon",
                "The Doors,The Doors"
            });
        }
    }
}
