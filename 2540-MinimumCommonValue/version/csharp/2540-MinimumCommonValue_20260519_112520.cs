// Last updated: 19/05/2026, 11:25:20
1public class Solution {
2    public int GetCommon(int[] nums1, int[] nums2) {
3        int m = nums1.Length;
4        int n = nums2.Length;
5        int p1 = 0;
6        int p2 = 0;
7
8        while (p1 < m && p2 < n)
9        {
10            if (nums1[p1] == nums2[p2]) return nums1[p1];
11            if (nums1[p1] > nums2[p2])
12            {
13                p2++;
14            }
15            else
16            {
17                p1++;
18            }
19        }
20
21        return -1;
22    }
23}