// Last updated: 03/08/2026, 09:28:29
1public class Solution {
2    public int SumIndicesWithKSetBits(IList<int> nums, int k) {
3        int sum = 0;
4        
5        for (int i = 0; i < nums.Count; i++)
6        {
7            int setBits = 0;
8            int n = i;
9
10            while (n > 0)
11            {
12                setBits += (n & 1);
13                n >>= 1;
14            }
15
16            if (setBits == k) sum += nums[i];
17        }
18
19        return sum;
20    }
21}