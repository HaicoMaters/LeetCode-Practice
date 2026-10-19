// Last updated: 19/10/2026, 11:28:53
1public class Solution {
2    public IList<int> TargetIndices(int[] nums, int target) {
3        int n = nums.Length;
4        int smallerCnt = 0; // count of nums smaller than target
5        int targetCnt = 0; // count of nums that are target;
6
7        List<int> ans = new List<int>();
8
9        for (int i = 0; i < n; i++)
10        {
11            int num = nums[i];
12            if (num == target)
13            {
14                targetCnt++;
15            }
16            else if (num < target)
17            {
18                smallerCnt++;
19            }
20        }
21
22        while (targetCnt > 0)
23        {
24            ans.Add(smallerCnt);
25            smallerCnt++;
26            targetCnt--;
27        }
28        
29
30        return ans;
31    }
32}