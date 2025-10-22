// Last updated: 22/10/2025, 12:34:26
public class Solution {
    // order (right, down ,left, up)
    int[][] dirs = new int[][]{new int[]{0, 1}, new int[]{1, 0}, new int[]{0, -1}, new int[]{-1, 0}};
    
    public IList<int> SpiralOrder(int[][] matrix) {
        int dir = 0; // 0 = right, 1 = down, 2 = left, 3 = up
        List<int> order = new List<int>();
        int m = matrix.Length;
        int n = matrix[0].Length;
        bool[,] visited = new bool[m,n];

        int i = 0;
        int j = 0;
        while (order.Count < m*n)
        {
            visited[i,j] = true;
            order.Add(matrix[i][j]);

            if(order.Count == m*n) break;

            int ni = i + dirs[dir][0];
            int nj = j + dirs[dir][1];
            
            while (!(ni >= 0 && ni < m && nj >= 0 && nj < n && !visited[ni,nj]))
            {
                dir = (dir + 1) % 4;
                ni = i + dirs[dir][0];
                nj = j + dirs[dir][1];
            }

            i = ni;
            j = nj;
        }

        return order;
    }
}