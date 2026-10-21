// Last updated: 21/10/2026, 10:14:17
1public class Solution {
2    public int[] RearrangeArray(int[] nums) {
3        int n = nums.Length;
4        int[] pos = new int[n/2];
5        int[] neg = new int[n/2];
6        int pi = 0;
7        int ni = 0;
8
9        foreach (int num in nums)
10        {
11            if (num < 0)
12            {
13                neg[ni] = num;
14                ni++;
15            }
16            else
17            {
18                pos[pi] = num;
19                pi++;
20            }
21        }
22
23        for (int i = 0; i < n/2; i++)
24        {
25            nums[i*2] = pos[i];
26            nums[(i*2) + 1] = neg[i];
27        }
28
29        return nums;
30    }
31}