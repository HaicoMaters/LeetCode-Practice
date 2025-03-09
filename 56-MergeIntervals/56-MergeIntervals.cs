public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length == 0) return new int[0][];

        // Sort intervals by the start value
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new List<int[]>();

        int currentStart = intervals[0][0];
        int currentEnd = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++) {
            if (intervals[i][0] <= currentEnd) {
                currentEnd = Math.Max(currentEnd, intervals[i][1]);
            } 
            else { 
                merged.Add(new int[] { currentStart, currentEnd });
                currentStart = intervals[i][0];
                currentEnd = intervals[i][1];
            }
        }

        merged.Add(new int[] { currentStart, currentEnd });

        return merged.ToArray();
    }
}
