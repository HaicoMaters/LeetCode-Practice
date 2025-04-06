// Last updated: 06/04/2025, 14:55:55
public class Solution {
    public int CountBattleships(char[][] board) {
         int ships = 0;
        
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[0].Length; j++)
            {
                if(board[i][j] == 'X') // Ship has been found
                {
                    Dfs(board, i, j); // DFS to find rest of ship
                    ships++;
                }
            }
        }
        
        return ships;
    }
    
    private void Dfs(char[][] board, int i, int j)
    {
        if(i < 0 || i >= board.Length || j<0 || j >= board[0].Length || board[i][j] == '.')
        {
            return;
        }
        
        board[i][j] = '.'; // Mark the cell as already checked
        
        Dfs(board, i, j+1);
        Dfs(board, i+1, j);
    }
}