// Last updated: 19/08/2026, 09:38:07
1public class Solution {
2    public int EvenNumberBitwiseORs(int[] nums) {
3        int ans = 0;
4
5        foreach (int num in nums)
6        {
7            if (num % 2 == 0)
8            {
9                ans |= num;
10            }
11        }
12
13        return ans;
14    }
15}