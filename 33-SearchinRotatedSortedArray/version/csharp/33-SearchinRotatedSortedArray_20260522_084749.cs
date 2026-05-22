// Last updated: 22/05/2026, 08:47:49
1public class Solution {
2    public int Search(int[] nums, int target) {
3        int n = nums.Length;
4        int l = 0;
5        int r = n -1;
6
7        while (l <= r)
8        {
9            int mid = (r - l) / 2 + l;
10            if (nums[mid] == target) return mid;
11
12            if (nums[mid] >= nums[l])
13            {
14                if (nums[l] <= target && target <= nums[mid])
15                {
16                    r = mid - 1;
17                }
18                else
19                {
20                    l = mid + 1;
21                }
22            }
23            else
24            {
25                if (nums[mid] <= target && nums[r] >= target)
26                {
27                    l = mid + 1;
28                }
29                else
30                {
31                    r = mid - 1;
32                }
33            }
34        }
35
36        return -1;
37    }
38}