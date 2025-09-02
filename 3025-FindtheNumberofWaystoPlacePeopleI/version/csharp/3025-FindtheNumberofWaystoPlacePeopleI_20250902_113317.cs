// Last updated: 02/09/2025, 11:33:17
public class Solution {
    public int NumberOfPairs(int[][] points) {
        int n = points.Length;
        int pairs = 0;

        Array.Sort(points, (a,b) => {
            if (a[0] == b[0]) return b[1].CompareTo(a[1]);
            return a[0].CompareTo(b[0]);
        });

        for (int i = 0; i < n; i++)
        {
            int top = points[i][1];
            int bottom = int.MinValue;

            for (int j = i + 1; j < n; j++)
            {
                int y = points[j][1];
                if(bottom < y && y <= top)
                {
                    pairs++;
                    bottom = y;
                    if (top == bottom) break;
                }
            }
        }

        return pairs;
    }
}