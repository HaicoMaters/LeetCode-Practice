// Last updated: 02/03/2025, 17:07:40
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution { // More efficient priority queue solution
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) return null;

        PriorityQueue<ListNode, int> pq = new PriorityQueue<ListNode, int>();

        // Push all the first nodes of the lists into the priority queue
        foreach (var list in lists) {
            if (list != null) {
                pq.Enqueue(list, list.val);
            }
        }

        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while (pq.Count > 0) {
            // Get the smallest element from the heap
            ListNode smallest = pq.Dequeue();
            current.next = smallest;
            current = current.next;

            // If the extracted node has a next node, add it to the heap
            if (smallest.next != null) {
                pq.Enqueue(smallest.next, smallest.next.val);
            }
        }

        return dummy.next;
    }
}
