// Last updated: 03/02/2026, 14:46:56
1public class Solution {
2    public bool IsTrionic(int[] nums) {
3        int n = nums.Length;
4        int i = 1;
5
6        while (i < n && nums[i-1] < nums[i])
7        {
8            i++;
9        }
10
11        int p = i - 1; // index where it stops increasing
12        while (i < n && nums[i-1] > nums[i])
13        {
14            i++;
15        }
16
17        int q = i-1; // index where it stops decreasing
18        while (i < n && nums[i-1] < nums[i])
19        {
20            i++;
21        }
22
23        return (p != 0) && (q != p) && (i-1 == n-1) && (i-1 != q); // check the rest is increasing
24    }
25}