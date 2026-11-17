// Last updated: 17/11/2026, 10:54:36
1public class Solution {
2    public int[][] DiagonalSort(int[][] mat) {
3        int m = mat.Length;
4        int n = mat[0].Length;
5
6        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
7        
8        // group into diagonals
9        for (int i = 0; i < m; i++)
10        {
11            for (int j = 0; j < n; j++)
12            {
13                int group = i - j;
14
15                if (!map.ContainsKey(group))
16                {
17                    map[group] = new List<int>();
18                }
19
20                map[group].Add(mat[i][j]);
21            }
22        }
23
24        // sort groups
25        foreach (var group in map.Keys)
26        {
27            map[group].Sort();
28        }
29
30        // update matrix
31        for (int i = 0; i < m; i++)
32        {
33            for (int j = 0; j < n; j++)
34            {
35                int group = i - j;
36                mat[i][j] = map[group][0];
37                map[group].RemoveAt(0);
38            }
39        }
40
41        return mat;
42    }
43}