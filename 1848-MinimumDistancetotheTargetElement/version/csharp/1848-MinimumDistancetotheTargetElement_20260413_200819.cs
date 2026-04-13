// Last updated: 13/04/2026, 20:08:19
1public class Solution {
2    public int GetMinDistance(int[] nums, int target, int start) {
3        int n =  nums.Length;
4        int minScore = n + 1;
5
6        if (nums[start] == target) return 0;
7        
8        for (int i = 0; i < n; i++)
9        {
10            if (nums[i] == target)
11            {
12                int score = Math.Abs(i - start);
13                if (score < minScore)
14                {
15                    minScore = score;
16                }
17            }
18        }
19
20        return minScore;
21    }
22}