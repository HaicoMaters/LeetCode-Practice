// Last updated: 14/07/2025, 11:59:42
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
    public int GetDecimalValue(ListNode head) {
        int value = 0;
        ListNode current = head;

        while (current != null)
        {
            value *= 2;
            value += current.val;

            current = current.next;
        }

        return value;
    }
}