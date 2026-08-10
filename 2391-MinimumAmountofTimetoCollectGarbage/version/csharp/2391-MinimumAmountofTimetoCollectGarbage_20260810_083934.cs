// Last updated: 10/08/2026, 08:39:34
1public class Solution {
2    public int GarbageCollection(string[] garbage, int[] travel) {
3        int n = garbage.Length;
4        int time = 0;
5
6        foreach (string s in garbage)
7        {
8            time += s.Length;
9        }
10
11        int lastM = -1, lastP = -1, lastG = -1;
12        int[] travelTimes = new int[n];
13
14        for (int i = 0; i < n; i++)
15        {
16            if (i != 0) travelTimes[i] = travelTimes[i-1] + travel[i-1];
17
18            if (garbage[i].Contains('M')) lastM = i;
19            if (garbage[i].Contains('P')) lastP = i;
20            if (garbage[i].Contains('G')) lastG = i;
21        }
22
23        if (lastM != -1) time += travelTimes[lastM];
24        if (lastP != -1) time += travelTimes[lastP];
25        if (lastG != -1) time += travelTimes[lastG];
26
27        return time;
28    }
29}