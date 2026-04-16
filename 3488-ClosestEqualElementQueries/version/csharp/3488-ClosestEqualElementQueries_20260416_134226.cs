// Last updated: 16/04/2026, 13:42:26
1public class Solution {
2    public IList<int> SolveQueries(int[] nums, int[] queries) {
3        int n = nums.Length;
4        int m = queries.Length;
5        int[] answer = new int[m];
6
7        Dictionary<int, List<int>> numIndexMap = new Dictionary<int, List<int>>();
8
9        for (int i = 0; i < n; i++)
10        {
11            if (!numIndexMap.ContainsKey(nums[i]))
12                numIndexMap[nums[i]] = new List<int>();
13
14            numIndexMap[nums[i]].Add(i);
15        }
16
17        int[] minDistances = new int[n];
18        Array.Fill(minDistances, -1);
19
20        foreach (var kvp in numIndexMap)
21        {
22            var list = kvp.Value;
23            int size = list.Count;
24
25            if (size == 1) continue;
26
27            for (int i = 0; i < size; i++)
28            {
29                int idx = list[i];
30                int next = list[(i + 1) % size];
31                int prev = list[(i - 1 + size) % size];
32
33                int d1 = Math.Abs(idx - next);
34                int d2 = Math.Abs(idx - prev);
35                int distNext = Math.Min(d1, n - d1);
36                int distPrev = Math.Min(d2, n - d2);
37
38                minDistances[idx] = Math.Min(distNext, distPrev);
39            }
40        }
41
42        for (int i = 0; i < m; i++)
43        {
44            int idx = queries[i];
45
46            if (idx < 0 || idx >= n)
47            {
48                answer[i] = -1;
49            }
50            else
51            {
52                answer[i] = minDistances[idx];
53            }
54        }
55
56        return answer;
57    }
58}