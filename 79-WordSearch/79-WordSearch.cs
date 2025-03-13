public class Solution {
    int[][] directions = new int[][]{new int[]{0, 1}, new int[]{0, -1}, new int[]{1, 0}, new int[]{-1, 0}};

    public bool Exist(char[][] board, string word) {
        bool[][] used = new bool[board.Length][];
        for (int i = 0; i < used.Length; i++){
            used[i] = new bool[board[0].Length];
        }

        int[] start = new int[]{0, 0}; // The current tile

        return BackTrack(board, word, 0, board.Length, board[0].Length, used);
    }

    public bool BackTrack(char[][] board, string word, int currentLength, int i, int j, bool[][] used)
    {
        if (currentLength == word.Length) return true;

        if (currentLength == 0) // Find Start of Word
        {
            for (int x = 0; x < board.Length; x++)
            {
                for (int y = 0; y < board[0].Length; y++)
                {
                    if (board[x][y] == word[0] && !used[x][y])
                    {
                        used[x][y] = true;
                        if (BackTrack(board, word, 1, x, y, used)) return true;
                        used[x][y] = false;
                    }
                }
            }
        }
        else // Find neighbours of current letter for next letter in word
        {
            foreach (int[] dir in directions)
            {
                int ni = i + dir[0];
                int nj = j + dir[1];

                if (ni >= 0 && nj >= 0 && ni < board.Length && nj < board[0].Length && !used[ni][nj] && board[ni][nj] == word[currentLength])
                {
                    used[ni][nj] = true;
                    if (BackTrack(board, word, currentLength + 1, ni, nj, used)) return true;
                    used[ni][nj] = false;
                }
            }
        }
        return false;
    }
}