// Last updated: 28/05/2025, 13:18:43
public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        // Queen cannot be in same column c or row r 
        // Queen cannot be in the diagnoals c +- x and r + y between zero and n 
        // Place Each Queen on a new row to avoid row conflicts
        List<IList<string>> boardStates = new List<IList<string>>();
        List<string> board = new List<string>();

        for (int i = 0; i < n; i++) // Initalise the board with empty squares
        {
            board.Add(new string('.', n));
        }

        SolveNQueens(n, boardStates, board, 0); // Start from row 0
        return boardStates;
    }

    // Recursive Function for backtracking
    void SolveNQueens(int n, IList<IList<string>> states, List<string> board, int row)
    {
        // All Queens in row found valid solution
        if (row == n)
        {
            states.Add(new List<string>(board));
            return;
        }

        // Try Placing queen in each col of current row
        for (int col = 0; col < n; col++)
        {
            if (IsValidSquare(n, board, row, col))
            {
                char[] chars = board[row].ToCharArray();
                chars[col] = 'Q';
                board[row] = new string(chars);

                // Solve for next row recursively
                SolveNQueens(n, states, board, row + 1);

                // Remove queen to backtrack and try the nex possible column position
                chars[col] = '.';
                board[row] = new string(chars);
            }
        }
    }

    bool IsValidSquare(int n, List<string> board, int row, int col) // Row is aways valid due to placements
    {
        // Check Column
        for (int i = 0; i < n; i++)
        {
            if (board[i][col] == 'Q') return false;
        }

        // Check Left Diagonal
        for (int i = row - 1, j = col -1; i>= 0 && j >= 0; i--, j--)
        {
            if (board[i][j] == 'Q') return false;
        }

        // Check Right Diagonal
        for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
        {
            if (board[i][j] == 'Q') return false;
        }

        return true;
    }
}