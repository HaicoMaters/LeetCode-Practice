// Last updated: 17/04/2026, 14:48:15
1public class Solution {
2    public int MinMirrorPairDistance(int[] nums) {
3        int n = nums.Length;
4        int minDistance = n;
5        Dictionary<int, int> numLastIndex = new Dictionary<int, int>(); // stores the last index where the mirrored number was
6
7        for (int i = 0; i < n; i++)
8        {
9            int num = nums[i];
10
11            if (numLastIndex.ContainsKey(nums[i]))
12            {
13                minDistance = Math.Min(minDistance, Math.Abs(i - numLastIndex[num]));
14            }
15            
16            // reverse the num
17            int reverse = 0;
18            while (num != 0)
19            {
20                reverse *= 10;
21                reverse += num % 10;
22                num /= 10;
23            }
24
25            numLastIndex[reverse] = i;
26        }
27
28
29        return (minDistance == n) ? -1 : minDistance;
30    }
31}