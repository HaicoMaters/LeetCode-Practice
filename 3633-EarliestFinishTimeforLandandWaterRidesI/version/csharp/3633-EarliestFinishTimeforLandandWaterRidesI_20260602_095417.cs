// Last updated: 02/06/2026, 09:54:17
1public class Solution {
2    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
3        int time = int.MaxValue;
4        int earliestLandEnd = int.MaxValue;
5        int earliestWaterEnd = int.MaxValue;
6        int m = landStartTime.Length;
7        int n = waterStartTime.Length;
8
9        for (int i = 0; i < m; i++)
10        {
11            earliestLandEnd = Math.Min(earliestLandEnd, landStartTime[i] + landDuration[i]);
12        }
13        
14        for (int j = 0; j < n; j++)
15        {
16            earliestWaterEnd = Math.Min(earliestWaterEnd, waterStartTime[j] + waterDuration[j]);
17        }
18        
19        // starting with earliest land
20        for (int j = 0; j < n; j++)
21        {
22            time = Math.Min(time, Math.Max(earliestLandEnd, waterStartTime[j]) + waterDuration[j]);
23        }
24
25        // starting with earliest water
26        for (int i = 0; i < m; i++)
27        {
28            time = Math.Min(time, Math.Max(earliestWaterEnd, landStartTime[i]) + landDuration[i]);
29        }
30
31        return time;
32    }
33}