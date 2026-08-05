// Last updated: 05/08/2026, 09:49:16
1public class Solution {
2    public int EarliestTime(int[][] tasks) {
3        int earliest = int.MaxValue;
4        
5        foreach (int[] task in tasks)
6        {
7            earliest = Math.Min(earliest, task[0] + task[1]);
8        }
9
10        return earliest;
11    }
12}