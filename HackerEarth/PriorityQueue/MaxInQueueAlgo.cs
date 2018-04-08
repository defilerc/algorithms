namespace HackerEarth.PriorityQueue
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class MaxInQueueAlgo
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queue = new List<int>();

            for (var i = 0; i < n; i++) {
                PriorityQueueInsert(queue, nums[i]);
            }
            
            var q = int.Parse(Console.ReadLine());
            
            while (q-- > 0) {
                var query = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (query[0] == 2) {
                    //Console.WriteLine(list.Max());
                    PriorityQueueMax(queue);
                    continue;
                }

                PriorityQueueInsert(queue, query[1]);
                //list.Add(query[1]);
            }

        }

        static int PriorityQueueMax(List<int> arr) => arr[0];

        static void PriorityQueueInsert(List<int> arr, int val)
        {
            arr.Insert(arr.Count, -1); //assuming all the numbers greater than 0 are to be inserted in queue.
            PriorityQueueIncreaseVal(arr, arr.Count - 1, val);
        }

        static void PriorityQueueIncreaseVal(List<int> arr, int i, int val)
        {
            if (val < arr[i]) {
                throw new ArgumentException("New value is less than current value, can’t be inserted");
            }

            arr[i] = val;
            while (i > 0 && arr[i / 2] < arr[i]) {

                // Swap arr[i] <-> arr[i/2]
                var tmp = arr[i/2]; arr[i/2] = arr[i]; arr[i] = tmp;

                i = i / 2;
            }
        }
    }
}
