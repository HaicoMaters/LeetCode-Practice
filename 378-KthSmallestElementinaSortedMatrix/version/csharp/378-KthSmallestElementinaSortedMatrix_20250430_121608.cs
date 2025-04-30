// Last updated: 30/04/2025, 12:16:08
public class Solution {
    public int KthSmallest(int[][] matrix, int k) { //O(1) memory solution
        int n = matrix.Length;
        int bound = Math.Min(k, n); // Shrink the bounds to the smaller of k and n
        int min = matrix[0][0]; // everything to right and below should be > than top left
        int max = matrix[n-1][n-1]; // everyting left and above should be < bottom right

        // Binary search on element values in matrix
        while (min < max)
        {
            int mid = min + (max - min) / 2;
            int count = CountLessEqual(matrix, mid, bound); // Find the number of values <= to mid

            if (count < k) min = mid + 1;
            else max = mid;
        }

        return min;
    }

    public int CountLessEqual(int[][] matrix, int mid, int bound)
    {
        int row = bound - 1;
        int col = 0;
        int count = 0;

        while (row >= 0 && col < bound) // Traversal bottom left, to top right to count all less or equal
        {
            if (matrix[row][col] <= mid)
            {
                count += row + 1; // count all in current column including rows above (above will always be less than or equal)
                col++; // Move right to next column
            }
            else
            {
                row--; // Current element is > target, move up to smaller values in this column in higher rows
            }
        }

        return count;
    }
}