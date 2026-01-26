// Last updated: 26/01/2026, 16:00:07
1public class Solution {
2    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
3        Array.Sort(arr);
4        List<IList<int>> pairs = new List<IList<int>>();
5        int n = arr.Length;
6
7        int minDiff = int.MaxValue;
8
9        for (int i = 0; i < n-1; i++)
10        {
11            minDiff = Math.Min(minDiff, arr[i+1] - arr[i]);
12        }
13
14        for (int i = 0; i < n-1; i++)
15        {
16            int diff = arr[i+1] - arr[i];
17
18            if (diff == minDiff)
19            {
20                pairs.Add(new List<int>{arr[i], arr[i+1]});
21            }
22        }
23
24        return pairs;
25    }
26}