// Last updated: 29/05/2026, 10:40:12
1public class Solution {
2    public int MinElement(int[] nums) {
3        int min = int.MaxValue;
4
5        for (int i = 0; i < nums.Length; i++)
6        {
7            int element = nums[i];
8            int digiSum = 0;
9            while (element > 0)
10            {
11                digiSum += element % 10;
12                element /= 10;
13            }
14
15            min = Math.Min(min, digiSum);
16        }
17
18        return min;
19    }
20}