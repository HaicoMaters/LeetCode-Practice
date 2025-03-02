public class Solution {
    // O(m * n) solution to the problem
    public void GameOfLife(int[][] board) {
        // m * n grid size
        int m = board.Length;
        int n = board[0].Length;

        // State transitions:
        // 0: dead -> dead, 1: alive -> alive, 2: dead -> alive, 3: alive -> dead

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                int liveNeighbors = 0;

                // Count live neighbors
                for (int k = -1; k <= 1; k++) {
                    for (int l = -1; l <= 1; l++) {
                        if (i + k >= 0 && i + k < m && j + l >= 0 && j + l < n && !(k == 0 && l == 0)) {
                            liveNeighbors += board[i + k][j + l] % 2; // Original state
                        }
                    }
                }

                // Update state based on the rules
                if (board[i][j] == 0) {
                    // Dead cell becomes alive if exactly 3 neighbors are alive
                    board[i][j] = (liveNeighbors == 3) ? 2 : 0;
                } else {
                    // Live cell stays alive if 2 or 3 neighbors are alive, otherwise dies
                    board[i][j] = (liveNeighbors == 2 || liveNeighbors == 3) ? 1 : 3;
                }
            }
        }

        // Use defintions to make the cell in the right state
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i][j] == 1 || board[i][j] == 2)
                {
                    board[i][j] = 1;
                }
                else
                {
                    board[i][j] = 0;
                }
            }
        }
    }
}
