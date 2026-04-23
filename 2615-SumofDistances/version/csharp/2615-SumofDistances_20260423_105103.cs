// Last updated: 23/04/2026, 10:51:03
1public class Solution {
2    public long[] Distance(int[] nums) {
3        int n = nums.Length;
4        long[] dist = new long[n];
5
6        Dictionary<int, List<int>> occur = new Dictionary<int, List<int>>();
7
8        for (int i = 0; i < n; i++)
9        {
10            int num = nums[i];
11            if (!occur.ContainsKey(num))
12            {
13                occur[num] = new List<int>();
14            }
15            occur[num].Add(i);
16        }
17
18        foreach (var group in occur.Values)
19        {
20            long total = 0;
21            foreach (int idx in group)
22            {
23                total += idx;
24            }
25
26            long pre = 0;
27            int size = group.Count;
28
29            for (int i = 0; i < size; i++)
30            {
31                int idx = group[i];
32                dist[idx] = total - (pre * 2) + ((long)idx * (2 * i - size));
33                pre += idx;
34            }
35        }
36
37        return dist;
38    }
39}