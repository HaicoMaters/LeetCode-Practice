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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode l = new ListNode(0);
        ListNode current = l;
        int lastVal = -101; // Default val outside of specified range to be replaced (-100 - 100)

        while (head != null)
        {   
            if (head.val != lastVal)
            {
                current.next = head;
                current = current.next;
                lastVal = current.val;
            }
            head = head.next;
        }

        current.next = null;
        
        return l.next;
    }
}