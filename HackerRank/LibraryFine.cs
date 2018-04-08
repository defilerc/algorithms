namespace HackerRank
{
    using System;
    using System.Linq;

    public class LibraryFine
    {
        public static void Main(string[] args)
        {
            var returnedStr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var expectedStr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var returned = new DateTime(returnedStr[2], returnedStr[1], returnedStr[0]);
            var expected = new DateTime(expectedStr[2], expectedStr[1], expectedStr[0]);

            if (returned <= expected) {
                Console.WriteLine(0);
                return;
            }

            if (returned.Year == expected.Year && returned.Month == expected.Month) {
                Console.WriteLine(15 * (returned - expected).Days);
                return;
            }

            if (returned.Year == expected.Year) {
                Console.WriteLine(500 * (returned.Month - expected.Month));
                return;
            }

            Console.WriteLine(10000);
        }
    }
}
