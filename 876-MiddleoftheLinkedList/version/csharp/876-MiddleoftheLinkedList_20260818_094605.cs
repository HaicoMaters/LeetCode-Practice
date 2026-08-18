// Last updated: 18/08/2026, 09:46:05
1/**
2 * Definition for singly-linked list.
3 * public class ListNode {
4 *     public int val;
5 *     public ListNode next;
6 *     public ListNode(int val=0, ListNode next=null) {
7 *         this.val = val;
8 *         this.next = next;
9 *     }
10 * }
11 */
12public class Solution {
13    public ListNode MiddleNode(ListNode head) {
14        int len = 0;
15        ListNode dummy = new ListNode();
16        dummy.next = head;
17        ListNode current = dummy;
18        
19        while (current.next != null)
20        {
21            len++;
22            current = current.next;
23        }
24
25        int mid = len/2;
26        int curr = 0;
27        current = dummy.next;
28        while (curr < mid)
29        {
30            curr++;
31            current = current.next;
32        }
33
34        return current;
35    }
36}