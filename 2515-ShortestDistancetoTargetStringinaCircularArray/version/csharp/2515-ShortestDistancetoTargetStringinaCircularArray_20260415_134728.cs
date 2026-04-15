// Last updated: 15/04/2026, 13:47:28
1public class Solution {
2    public int ClosestTarget(string[] words, string target, int startIndex) {
3        int n = words.Length;
4        int minDistance = -1;
5        for (int i = 0; i < n; i++)
6        {
7            if (words[i] == target)
8            {
9                if (i == startIndex) return 0;
10
11                int forwardDist = (i - startIndex + n) % n;
12                int backwardDist = (startIndex - i + n) % n;
13
14                if (minDistance == -1)
15                {
16                    minDistance = Math.Min(forwardDist, backwardDist);
17                }
18
19                minDistance = Math.Min(Math.Min(minDistance, forwardDist), backwardDist);
20            }
21        }
22
23        return minDistance;
24    }
25}