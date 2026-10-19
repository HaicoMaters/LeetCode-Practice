// Last updated: 19/10/2026, 11:24:43
1public class Solution {
2    public IList<int> TargetIndices(int[] nums, int target) {
3        int n = nums.Length;
4        Array.Sort(nums);
5
6        List<int> ans = new List<int>();
7
8        for (int i = 0; i < n; i++)
9        {
10            int num = nums[i];
11            if (num == target)
12            {
13                ans.Add(i);
14            }
15            else if (num > target) break;
16        }
17
18        return ans;
19    }
20}