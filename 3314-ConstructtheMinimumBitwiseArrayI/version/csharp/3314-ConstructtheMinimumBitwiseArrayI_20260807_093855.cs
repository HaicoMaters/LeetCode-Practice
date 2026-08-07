// Last updated: 07/08/2026, 09:38:55
1public class Solution {
2    public int[] MinBitwiseArray(IList<int> nums) {
3        int n = nums.Count;
4        int[] ans = new int[n];
5
6        for (int i = 0; i < n; i++)
7        {
8            int num = nums[i];
9            int minBitwise = -1;
10            for (int j = 1; j < num; j++)
11            {
12                if((j | (j+1)) == num)
13                {
14                    minBitwise = j;
15                    break;
16                }
17            }
18            ans[i] = minBitwise;
19        }
20
21        return ans;
22    }
23}