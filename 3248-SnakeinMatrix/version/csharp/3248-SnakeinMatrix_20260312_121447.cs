// Last updated: 12/03/2026, 12:14:47
1public class Solution {
2    public int FinalPositionOfSnake(int n, IList<string> commands) {
3        int i = 0;
4        int j = 0;
5
6        foreach (string command in commands)
7        {
8            switch(command)
9            {
10                case "UP":
11                    i--;
12                    break;
13                case "DOWN":
14                    i++;
15                    break;
16                case "LEFT":
17                    j--;
18                    break;
19                case "RIGHT":
20                    j++;
21                    break;
22            }
23        }
24        if (i < 0 || j < 0) return -1;
25        return (i * n) + j;
26    }
27}