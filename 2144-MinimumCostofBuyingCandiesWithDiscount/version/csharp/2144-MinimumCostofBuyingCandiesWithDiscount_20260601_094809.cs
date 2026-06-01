// Last updated: 01/06/2026, 09:48:09
1public class Solution {
2    public int MinimumCost(int[] cost) {
3        Array.Sort(cost);
4        int minCost = 0;
5        int cycle = 0; //0, 1 ,2 (free) -> 0, 1 ,2
6
7        for (int i = cost.Length - 1; i >= 0; i--)
8        {
9            if (cycle < 2)
10            {
11                minCost += cost[i];
12            }
13
14            cycle = (cycle + 1) % 3;
15        }
16        
17        return minCost;
18    }
19}