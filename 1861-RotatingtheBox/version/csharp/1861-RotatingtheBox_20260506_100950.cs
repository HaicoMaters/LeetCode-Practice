// Last updated: 06/05/2026, 10:09:50
1public class Solution {
2    public char[][] RotateTheBox(char[][] boxGrid) {
3        int m = boxGrid.Length;
4        int n = boxGrid[0].Length;
5        char[][] rotated = new char[n][];
6
7        for (int i = 0; i < n; i++)
8        {
9            rotated[i] = new char[m];
10        }
11
12        
13        // build the rotated box pre-gravity application
14        for (int i = 0; i < n; i++)
15        {
16            for (int j = 0; j < m; j++)
17            {
18                rotated[i][j] = boxGrid[m - 1 - j][i];
19            }
20        }
21
22        // apply gravity from bottom-up
23        for (int col = 0; col < m; col++)
24        {
25            int emptyRow = n - 1; // the last free row to drop down to
26
27            for (int row = n-1; row >= 0; row--)
28            {
29                if (rotated[row][col] == '*') // stationary obstacle blocking dropdown
30                {
31                    emptyRow = row - 1;
32                }
33                else if (rotated[row][col] == '#')
34                {
35                    rotated[row][col] = '.';
36                    rotated[emptyRow][col] = '#';
37                    emptyRow--;
38                }
39            }
40        }
41
42        return rotated;
43    }
44}