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
    public ListNode MergeKLists(ListNode[] lists) {
        ListNode head = new ListNode();
        ListNode current = head;
        int n = lists.Length;

        if (lists == null || lists.Length == 0) return head.next;
        
        bool finished = false;
        while(!finished)
        {
            int listIndex = -1;
            int lowestValue = 0;
            for (int i = 0; i < n; i++)
            {
                if (lists[i] == null) continue;

                if(listIndex == -1)
                {
                    listIndex = i;
                    lowestValue = lists[i].val;
                } 

                if (lists[i].val < lowestValue)
                {
                    listIndex = i;
                    lowestValue = lists[i].val;
                }
            }
            
            if (listIndex == -1) 
            {
                current.next = null;
                finished = true;

            }
            else
            {
                current.next = lists[listIndex];
                current = current.next;
                lists[listIndex] = lists[listIndex].next;
            }
        }

        return head.next;
    }
}