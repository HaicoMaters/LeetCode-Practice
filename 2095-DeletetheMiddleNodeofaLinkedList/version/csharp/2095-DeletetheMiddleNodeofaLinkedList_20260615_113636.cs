// Last updated: 15/06/2026, 11:36:36
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
13    public ListNode DeleteMiddle(ListNode head) {
14        int count = 0;
15        ListNode current = head;
16
17        while (current != null)
18        {
19            count++;
20            current = current.next;
21        }
22
23        if (count == 1) return null;
24
25        int mid = count/2;
26        count = 0;
27        current = head;
28
29        while (count < mid-1)
30        {
31            count++;
32            current = current.next;
33        }
34
35        current.next = current.next.next;
36        return head;
37    }
38}