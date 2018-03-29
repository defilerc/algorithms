using System.Linq;

namespace HackerEarth.Disjoint
{
    public class DisjointAlgo
    {
        public static void Main(string[] args)
        {

        }

        public static int[] Init(int length)
        {
            return Enumerable.Range(0, length + 1).ToArray();
        }

        public static bool Find(int[] array, int a, int b)
        {
            return a < array.Length && b < array.Length && array[a] == array[b];
        }

        /// <summary>
        /// Connect array[a] with array[b], by making array[a] = array[b]
        /// </summary>
        /// <param name="array"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Union(int[] array, int a, int b)
        {
            var tmp = array[a];
            for (var i = 0; i < array.Length; i++) {
                if (array[i] == tmp) {
                    array[i] = array[b];
                }
            }
        }
    }
}
