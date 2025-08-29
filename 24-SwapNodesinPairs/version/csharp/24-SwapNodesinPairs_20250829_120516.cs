// Last updated: 29/08/2025, 12:05:16
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
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null) return head;

        ListNode node = SwapPairs(head.next.next);

        // swap and attach node from original second to original first (now second)
        ListNode temp = head;
        head = head.next;
        head.next = temp;
        head.next.next = node;

        return head;
    }
}