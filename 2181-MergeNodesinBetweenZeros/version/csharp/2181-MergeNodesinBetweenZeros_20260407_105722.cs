// Last updated: 07/04/2026, 10:57:22
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
13    public ListNode MergeNodes(ListNode head) {
14        ListNode dummy = new ListNode(0);
15        ListNode merge = dummy;
16        ListNode current = head.next; 
17        int sum = 0;
18
19        while (current != null)
20        {
21            if (current.val == 0)
22            {
23                merge.next = new ListNode(sum);
24                merge = merge.next;
25                sum = 0;
26            }
27            else
28            {
29                sum += current.val;
30            }
31
32            current = current.next;
33        }
34
35        return dummy.next;
36    }
37}