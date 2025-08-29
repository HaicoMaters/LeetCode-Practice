// Last updated: 29/08/2025, 11:49:06
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int L = 0;
        int R = m*n-1;

        while (L <= R)
        {
            int mid = L + (R - L / 2);
            int val = matrix[mid/n][mid%n];

            if (val == target) return true;

            if (val < target)
            {
                L = mid+1;
            }
            else
            {
                R = mid-1;
            }
        }

        return false;
    }
}