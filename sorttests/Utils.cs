using Algo;

namespace AlgoTests
{
    public class Utils
    {
        public static ListNode<int> CreateLinkedList(int[] values)
        {
            ListNode<int> prev = null;
            ListNode<int> head = null;

            foreach (var v in values) {
                var node = new ListNode<int> {
                    value = v,
                };

                if (head == null) {
                    head = node;
                }

                if (prev != null) {
                    prev.next = node;
                }

                prev = node;
            }

            return head;
        }
    }
}
