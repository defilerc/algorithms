namespace HackerEarth
{
    using System;
    using System.Linq;

    public class _1DArray
    {
        public static void Main(string[] args)
        {
            var array = new int[int.Parse(Console.ReadLine())];

            for (var i = 0; i < array.Length; i++) {
                array[i] = int.Parse(Console.ReadLine());
            }

            foreach (var i in array.Reverse()) {
                Console.WriteLine(i);
            }
        }
    }
}
