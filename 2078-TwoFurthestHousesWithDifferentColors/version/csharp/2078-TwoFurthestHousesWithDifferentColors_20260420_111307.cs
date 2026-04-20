// Last updated: 20/04/2026, 11:13:07
1public class Solution {
2    public int MaxDistance(int[] colors) {
3        int maxDist = 0;
4        int n = colors.Length;
5        int leftCol = colors[0];
6        int i = n-1;
7
8        while (colors[i] == leftCol)
9        {
10            i--;
11        }
12
13        maxDist = i;
14
15        int rightCol = colors[n -1];
16        i = 0;
17        while (colors[i] == rightCol)
18        {
19            i++;
20        }
21
22        maxDist = Math.Max(maxDist, n - 1 - i);
23
24        return maxDist;
25    }
26}