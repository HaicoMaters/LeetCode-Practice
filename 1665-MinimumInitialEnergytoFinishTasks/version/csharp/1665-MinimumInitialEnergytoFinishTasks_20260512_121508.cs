// Last updated: 12/05/2026, 12:15:08
1public class Solution {
2    public int MinimumEffort(int[][] tasks) {
3        // prio tasks with larger differences (min[i] - act[i]) to reduce waste of energy
4        Array.Sort(tasks, (a,b) => (a[1] - a[0]).CompareTo(b[1] - b[0]));
5        int requiredEffort = 0;
6
7        foreach (int[] task in tasks)
8        {
9            requiredEffort = Math.Max(requiredEffort + task[0], task[1]);
10        }
11
12        return requiredEffort;
13    }
14}