// Last updated: 28/08/2025, 11:16:52
public class Solution {
    public int[][] SortMatrix(int[][] grid) {
        // just need to sort starting from first row and first col

        int n = grid.Length;
        PriorityQueue<int, int> order = new PriorityQueue<int,int>();
        
        // Diagonals along the first col including the middle (bottom-left triangle) non-increasing order
        for (int j = 0; j < n; j++)
        {
            int row = j;
            int col = 0;

            while (row < n && col < n)
            {
                int val = grid[row][col];
                order.Enqueue(val,-val);
                row++;
                col++;
            }

            row = j;
            col = 0;
            while (order.Count > 0)
            {
                grid[row][col] = order.Dequeue();
                row++;
                col++;
            }
        }

        // Diagonals along the first row not including the middle (top right triangle) non-decreasing order
        for (int i = 1; i < n; i++)
        {
            int row = 0;
            int col = i;

            while (row < n && col < n)
            {
                int val = grid[row][col];
                order.Enqueue(val,val);

                row++;
                col++;
            }

            row = 0;
            col = i;
            while (order.Count > 0)
            {
                grid[row][col] = order.Dequeue();
                row++;
                col++;
            }
        }

        return grid;
    }
}