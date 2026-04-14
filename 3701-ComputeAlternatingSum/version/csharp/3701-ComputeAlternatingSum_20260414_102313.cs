// Last updated: 14/04/2026, 10:23:13
1public class Solution {
2    public int AlternatingSum(int[] nums) {
3        bool add = true;
4        int sum = 0;
5
6        for (int i = 0; i < nums.Length; i++)
7        {
8            if(add)
9            {
10                sum += nums[i];
11            }
12            else
13            {
14                sum -= nums[i];
15            }
16
17            add = !add;
18        }
19
20        return sum;
21    }
22}