using System.Data.SqlTypes;

namespace Algo
{
    public class ReverseNodesInKGroups
    {
        public ListNode<int> reverseNodesInKGroups(ListNode<int> l, int k) 
        {

            var cur = l;
            var head = l;
            var prev = l;

            var length = 0;
            while (cur != null) {
                length++;
                cur = cur.next;
            }

            var totalReversals = (length / k);

            cur = l;
            ListNode<int> prevEdge = l;
            ListNode<int> curEdge = l;

            var curIndex = 0;
    
            while (cur != null) {

                var next = cur.next;
        
                if (curIndex % k == 0) {
                    prevEdge = curEdge;
                    curEdge = cur;

                    prev = curEdge;
                } else if (curIndex <= totalReversals * k) {
                    cur.next = prev;
                    prev = cur;
                }

                if (curIndex == k - 1) {
                    head = cur;
                }
        
                if (curIndex > k && 
                  (curIndex % k == (k - 1) || cur.next == null)) {
                    prevEdge.next = cur;
                } 

                cur = next;
                curIndex++;
            }
    
            curEdge.next = null;
            return head;
        }

        public ListNode<int> reverseNodesInKGroups2(ListNode<int> l, int k)
        {
            var head = l;
            var prevHead = head;
            var reversedList = Reverse(head, k);

            prevHead.next = reversedList.HeadNext;
            var newHead = reversedList.Head;

            while (reversedList.HeadNext != null) {
                head = reversedList.HeadNext;
                reversedList = Reverse(head, k);
                prevHead.next = reversedList.Head;
                prevHead = head;
            }

            return newHead;
        }

        private ListInfo Reverse(ListNode<int> head, int k)
        {
            var cur = head;

            ListNode<int> prev = null;
            ListNode<int> next = null;

            var reversals = 0;
            var length = 0;
            while (cur != null) {
                length++;
                cur = cur.next;
            }

            if (length < k) {
                return new ListInfo {
                    Head = head,
                    HeadNext = head.next
                };
            }

            cur = head;

            while (cur != null && reversals++ < k) {
                next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }

            return new ListInfo {
                Head = prev,
                HeadNext = next
            };
        }

        public class ListInfo
        {
            public ListNode<int> Head { get; set; }
            public ListNode<int> HeadNext { get; set; }
        }
    }
}
