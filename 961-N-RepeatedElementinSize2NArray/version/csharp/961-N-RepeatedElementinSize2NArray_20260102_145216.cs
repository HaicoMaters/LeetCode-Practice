// Last updated: 02/01/2026, 14:52:16
1public class Solution {
2    public int RepeatedNTimes(int[] nums) {
3        HashSet<int> unique = new HashSet<int>();
4
5        foreach (int num in nums)
6        {
7            if (unique.Contains(num)) return num; // n + 1 unique so only one repeated num
8            unique.Add(num);
9        }
10
11        return -1;
12    }
13}