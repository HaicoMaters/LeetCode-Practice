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
    public ListNode ReverseList(ListNode head) {
        ListNode last = null;
        ListNode current = head;
        ListNode nextNode = null;

        while (current != null) 
        {
            nextNode = current.next; // Save next node
            current.next = last; // Reverse link
            last = current; // Move to next position
            current = nextNode;
        }

        return last;
    }
}