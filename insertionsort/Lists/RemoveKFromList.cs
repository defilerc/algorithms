namespace Algo
{
    public class RemoveKFromList
    {
        // Definition for singly-linked list:
        class ListNode<T>
        {
            public T value { get; set; }
            public ListNode<T> next { get; set; }
        }
        //
        ListNode<int> removeKFromList(ListNode<int> l, int k) {
            
            var head = l;
            ListNode<int> prev = null;
    
            while (l != null) {
                if (l.value == k) {
                    if (prev != null) {
                        prev.next = l.next;
                    } else {
                        prev = null;
                        head = l.next;
                    }
                } else {
                    prev = l;
                }
        
                l = l.next;
            }
    
            return head;
        }
    }
}
