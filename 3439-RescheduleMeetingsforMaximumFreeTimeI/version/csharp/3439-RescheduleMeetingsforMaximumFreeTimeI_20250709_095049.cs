// Last updated: 09/07/2025, 09:50:49
public class Solution {
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime) {
        int n = startTime.Length;
        int maxFreeTime = 0;

        int[] gaps = new int[n+1];
        gaps[0] = startTime[0];
        gaps[n] = eventTime - endTime[n-1];
        for (int i = 1; i < n; i++)
        {
            gaps[i] = startTime[i] - endTime[i-1];
        }

        int[] sum = new int[n+2];
        for (int i = 1; i <= n+1; i++)
        {
            sum[i] = sum[i-1] + gaps[i-1];
        }

        for (int i = k+1; i <= n+1; i++)
        {
            maxFreeTime = Math.Max(maxFreeTime, sum[i] - sum[i-(k+1)]);
        }

        return maxFreeTime;
    }
}