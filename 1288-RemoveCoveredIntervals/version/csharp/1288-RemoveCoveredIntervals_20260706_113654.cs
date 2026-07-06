// Last updated: 06/07/2026, 11:36:54
1public class Solution {
2    public int RemoveCoveredIntervals(int[][] intervals) {
3        int n = intervals.Length;
4        int count = 0;
5
6        for (int i = 0; i < n; i++)
7        {
8            int li = intervals[i][0];
9            int ri = intervals[i][1];
10            
11            bool redundant = false;
12
13            for (int j = 0; j < n; j++)
14            {
15                if (i == j) continue;
16
17                int lj = intervals[j][0];
18                int rj = intervals[j][1];
19
20                if (lj <= li && rj >= ri)
21                {
22                    redundant = true;
23                    break;
24                }
25            }
26
27            if (!redundant) count++;
28        }
29
30        return count;
31    }
32}