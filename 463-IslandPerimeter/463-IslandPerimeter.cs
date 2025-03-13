public class Solution {
    public int[][] neighbours = new int[][]{new int[]{1, 0}, new int[]{-1, 0}, new int[]{0, 1}, new int[]{0, -1}};

    public int IslandPerimeter(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        int perimeter = 0;

        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                if (grid[i][j] == 0) continue;

                int neighbourLand = 0; // number of neighbours with value of 1

                foreach (int[] neighbour in neighbours){
                    int ni = i + neighbour[0]; 
                    int nj = j + neighbour[1];

                    if (ni > - 1 && nj > -1 && ni < rows && nj < cols){
                        neighbourLand += grid[ni][nj];
                    }
                }

                perimeter += 4 - neighbourLand;
            }
        }

        return perimeter;
    }
}