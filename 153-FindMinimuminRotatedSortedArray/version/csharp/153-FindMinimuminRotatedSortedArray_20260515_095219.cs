// Last updated: 15/05/2026, 09:52:19
1public class Solution {
2    public int FindMin(int[] nums) {
3        int n = nums.Length;
4        int l = 0;
5        int r = n - 1;
6        
7        while (l < r)
8        {
9            int mid = l + (r - l) / 2;
10
11            if (nums[mid] < nums[r])
12            {
13                r = mid;
14            }
15            else
16            {
17                l = mid + 1;
18            }
19        }
20
21        return nums[l];
22    }
23}