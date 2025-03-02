public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool[] used = new bool[9];

        // Check Columns
        for (int i = 0; i < 9; i++) 
        {
            Array.Fill(used, false); // Clear for new column
            for (int j = 0; j < 9; j++) 
            {
                if (board[i][j] != '.') 
                { 
                    int num = board[i][j] - '1'; // Convert '1'-'9' to index 0-8
                    if (used[num]) return false;
                    used[num] = true;
                }
            }
        }

        // Check Rows
        for (int i = 0; i < 9; i++) 
        {
            Array.Fill(used, false); // Clear for new row
            for (int j = 0; j < 9; j++) 
            {
                if (board[j][i] != '.') 
                { 
                    int num = board[j][i] - '1'; // Convert '1'-'9' to index 0-8
                    if (used[num]) return false;
                    used[num] = true;
                }
            }
        }

         // Check 3x3 Sub-boxes
        for (int boxRow = 0; boxRow < 3; boxRow++) 
        {
            for (int boxCol = 0; boxCol < 3; boxCol++) 
            {
                Array.Fill(used, false); // Clear for new 3x3 box
                for (int i = 0; i < 3; i++) 
                {
                    for (int j = 0; j < 3; j++) 
                    {
                        int row = boxRow * 3 + i;
                        int col = boxCol * 3 + j;
                        if (board[row][col] != '.') 
                        {
                            int num = board[row][col] - '1'; // Convert '1'-'9' to index 0-8
                            if (used[num]) return false;
                            used[num] = true;
                        }
                    }
                }
            }
        }

        return true;
    }
}
