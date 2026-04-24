// Last updated: 24/04/2026, 11:11:19
1public class Solution {
2    public int FurthestDistanceFromOrigin(string moves) {
3        int blanks = 0;
4        int move = 0;
5
6        foreach (char c in moves)
7        {
8            if (c == 'L')
9            {
10              move--;  
11            }
12            if (c == 'R')
13            {
14                move++;
15            }
16            if (c == '_')
17            {
18                blanks++;
19            }
20        }
21
22        return (move > 0) ? move + blanks : Math.Abs(move - blanks);
23    }
24}