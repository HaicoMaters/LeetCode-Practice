public class Solution {
    public int[][] GenerateMatrix(int n) {
        int x = 0; // Treat the top left as 0,0 so the bottom left is 0, n (as opossed to traditional axis)
        int y = 0;
        int[][] matrix = new int[n][];
        for (int i = 0; i < n; i++) {
            matrix[i] = new int[n];
        }
        int value = 1;
        bool horizontal = true;
        int direction = 1; // +1 if righ or down, -1 if left or up
        // [t, 1] -> [f, 1] -> [t, -1] -> [f, -1] -> [t, 1]  Are the possible directional changes (right, down, left, up, left)

        for (int i = 0; i < n * n; i++)
        {
            matrix[y][x] = value;

            if (x == 0 && y == 0)
            {
                value++;
                x += direction;
                continue;
            }

            // Determine Next Space
            if (horizontal)
            {
                if(x == 0 || x == n - 1 || matrix[y][x+direction] != 0) // change direction
                {
                    horizontal = false;
                    // Down is considered positive so do not change direction
                    y += direction;
                }
                else x += direction; // Continue in direction
            }
            else
            {
                if(y == 0 || y == n - 1 || matrix[y+direction][x] != 0) // change direction
                {
                    horizontal = true;
                    direction = -direction; // left is considered negative so change direction
                    x += direction;
                }
                else y += direction; // continue in direction
            }

            value++;
        }

        return matrix;
    }
}