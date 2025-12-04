// Last updated: 04/12/2025, 14:49:36
1public class Solution {
2    public int CountCollisions(string directions) {
3        // if R at end or L at start no collision there (and any consecutive of same direction)
4
5        int collisions = 0;
6        int cars = directions.Length;
7
8        int i = 0;
9        int j = cars -1;
10
11        while (i < cars && directions[i] == 'L') 
12        {
13            i++;
14        }
15
16        while (j >= 0 && directions[j] == 'R') 
17        {
18            j--;
19        }
20
21        for (int k = i; k <= j; k++)
22        {
23            if (directions[k] != 'S') collisions++; // don't count stationary
24        }
25
26        return collisions;
27    }
28}