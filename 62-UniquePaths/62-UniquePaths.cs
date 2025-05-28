// Last updated: 28/05/2025, 13:18:37
public class Solution {
    public int UniquePaths(int m, int n) {
        int[,] paths = new int[m,n]; // count of paths until that point

        for (int i = 0; i < m; i++) // top row can only have 1 path (cannot move left/up)
        {
            paths[i,0] = 1;
        }

        for (int j = 0; j < n; j++) // left row can only have 1 path (cannot move left/up)
        {
            paths[0,j] = 1;
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                paths[i,j] = paths[i-1,j] + paths[i,j-1]; // at [i,j] paths are all the paths from the cell to the left + the cell above
            }
        }

        return paths[m-1, n-1];
    }
}