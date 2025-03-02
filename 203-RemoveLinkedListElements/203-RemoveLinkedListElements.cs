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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode l = new ListNode(0);
        ListNode current = l;

        while (head != null)
        {
            if (head.val != val)
            {
                current.next = head;
                current = current.next;
            }
            
            head = head.next;
        }
        
        current.next = null;
        return l.next;
    }
}