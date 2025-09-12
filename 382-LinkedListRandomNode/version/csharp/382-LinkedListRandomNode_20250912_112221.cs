// Last updated: 12/09/2025, 11:22:21
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
    int depth;
    Random rand;
    ListNode listHead;

    public Solution(ListNode head) {
        depth = 0;
        listHead = head;
        ListNode current = head;
        rand = new Random();
        while (current != null)
        {
            depth++;
            current = current.next;
        }    
    }
    
    public int GetRandom() {
        int idx = rand.Next(0, depth);
        
        ListNode current = listHead;
        while (idx > 0)
        {
            current = current.next;
            idx--;
        }

        return current.val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */