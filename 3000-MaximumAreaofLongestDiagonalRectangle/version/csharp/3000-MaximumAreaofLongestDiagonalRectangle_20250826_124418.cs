// Last updated: 26/08/2025, 12:44:18
public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        // diagonal is just pythag - a^2 + b^2 = c^2 (find biggest c^2 no need to sqrt)
        int maxDiagonalSquared = 0; // squared length of longest diagonal
        int area = 0;

        foreach (int[] rectangle in dimensions)
        {
            int diagonalSquared =  (rectangle[0] * rectangle[0]) + (rectangle[1] * rectangle[1]);

            if (diagonalSquared > maxDiagonalSquared)
            {
                maxDiagonalSquared = diagonalSquared;
                area = rectangle[0] * rectangle[1];
            }
            else if (diagonalSquared == maxDiagonalSquared)
            {
                area = Math.Max(area, rectangle[0] * rectangle[1]);
            }
        }

        return area;
    }
}