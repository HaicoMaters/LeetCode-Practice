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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
         ListNode l = new ListNode(0); 
         ListNode current = l; 
         int carryOn = 0;    

        while (l1 != null || l2 != null || carryOn > 0)
        {
            int valTotal = carryOn;
            
            if (l1 != null) 
            {
                valTotal += l1.val;
                l1 = l1.next;
            }

            if (l2 != null) 
            {
                valTotal += l2.val;
                l2 = l2.next;
            }

            carryOn = valTotal / 10; 

            current.next = new ListNode(valTotal % 10);
            current = current.next;
        }

    return l.next; 
 }
}