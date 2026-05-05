// Last updated: 05/05/2026, 09:38:03
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
13    public ListNode RotateRight(ListNode head, int k) {
14        if (head == null) return head;
15        // grab the last k nodes and bring to the front
16        int length = 0;
17        ListNode current = head;
18
19        while (current != null)
20        {
21            length++;
22            current = current.next;
23        }
24
25        int shift = k % length; // the starting index of nodes to bring to the front of the list
26        if (shift == 0) return head;
27        int startIndex = length - shift;
28        ListNode newStart = new ListNode(0);
29        current = head;
30        int idx = 0;
31
32        // get the rotated start from the end of the old list
33        while (idx < startIndex)
34        {
35            current = current.next;
36            idx++;
37        }
38
39        newStart.next = current;
40
41        // move the rest of the list behind the current list
42        idx = 0;
43        current = newStart.next;
44        while (idx < length - 1)
45        {
46            if (idx == length - startIndex - 1)
47            {
48                current.next = head;
49            }
50            current = current.next;
51            idx++;
52        }
53        current.next = null;
54
55        return newStart.next;
56    }
57}