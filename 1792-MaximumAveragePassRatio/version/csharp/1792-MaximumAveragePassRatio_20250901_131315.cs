// Last updated: 01/09/2025, 13:13:15
public class Solution {
    public double MaxAverageRatio(int[][] classes, int extraStudents) {
        double sum = 0.0;

        var pq = new PriorityQueue<(int pass, int total), double>();

        foreach (int[] c in classes)
        {
            int pass = c[0];
            int total = c[1];
            sum += (double) pass/total;
            pq.Enqueue((pass,total), -Gain(pass, total));
        }

        while (extraStudents > 0)
        {
            (int pass, int total) = pq.Dequeue();
            sum -= (double) pass/total;
            pass++;
            total++;
            sum += (double) pass/total;
            pq.Enqueue((pass,total), -Gain(pass, total));
            extraStudents--;
        }

        return sum / classes.Length;
    }

    public double Gain(int pass, int total)
    {
        return (double)(pass+1)/(total+1) - (double)pass/total;
    }
}