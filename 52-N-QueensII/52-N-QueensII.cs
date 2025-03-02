public class Solution {
    public int TotalNQueens(int n) {
        return TotalNQueens(n, 0, new Dictionary<int, int>());
    }
    
    int TotalNQueens(int n, int row, Dictionary<int, int> occupied)
    {
        if (row == n) return 1; // new solution found
        
        int solutions = 0;
        // Try Placing queen in each col of current row
        for (int col = 0; col < n; col++)
        {
            if (IsValidSquare(n, row, col, occupied))
            {
                occupied.Add(row, col);
                solutions += TotalNQueens(n, row + 1, occupied);
                occupied.Remove(row);
            }
        }

        return solutions;
    }

    bool IsValidSquare(int n, int row, int col, Dictionary<int, int> occupied) // Row is aways valid due to placements
    {
        // Check Column
        for (int i = 0; i < row; i++)
        {
            if (occupied[i] == col) return false;
        }

        // Check Left Diagonal
        for (int i = row - 1, j = col -1; i>= 0 && j >= 0; i--, j--)
        {
            if (occupied[i] == j) return false;
         }

        // Check Right Diagonal
        for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
        {
            if (occupied[i] == j) return false;
        }

        return true;
    }
}