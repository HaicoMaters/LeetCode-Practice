// Last updated: 02/12/2025, 14:03:14
1public class Solution {
2    public int CountTrapezoids(int[][] points) {
3        const long MOD = 1000000007;
4        long count = 0;
5
6        Dictionary<int, int> yCounts = new Dictionary<int, int>();
7
8        foreach (int[] point in points)
9        {
10            if(!yCounts.ContainsKey(point[1]))
11            {
12                yCounts[point[1]] = 0;
13            }
14
15            yCounts[point[1]] ++;
16        }  
17
18        List<long> parallels = new List<long>();
19
20        foreach (var kvp in yCounts)
21        {
22            if (kvp.Value > 1)
23            {
24                parallels.Add((((long)kvp.Value * (kvp.Value -1)) /2) % MOD);
25            }
26        } 
27
28        if (parallels.Count < 2) return 0;
29
30        List<long> prefix = new List<long>();
31        prefix.Add(parallels[0]);
32
33        for (int i = 1; i < parallels.Count; i++)
34        {
35            prefix.Add((parallels[i] + prefix[i-1]) % MOD);
36        }      
37
38        for (int i = parallels.Count - 1; i > 0; i--)
39        {
40            count = (count + (prefix[i-1] * parallels[i]) % MOD) % MOD;
41        }
42
43        return (int)count;
44    } 
45}