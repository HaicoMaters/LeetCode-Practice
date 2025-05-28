// Last updated: 28/05/2025, 13:14:12
public class Solution {
    // Neighbouring directions just to make easy to iterate over
    public int[][] directions = {new int[]{0, 1}, new int[]{0, -1},  new int[]{1, 0}, new int[]{-1, 0}};

    public int MaximumSafenessFactor(IList<IList<int>> grid) {
        int n = grid.Count; // Goal is n-1, n-1

        if (grid[0][0] == 1 || grid[n-1][n-1] == 1) return 0;

        Queue<int[]> queue = new Queue<int[]>();
        int[,] tiles = new int[n,n]; // Copy of grid as an array to make modifications easier

        // Initalise tiles
        for (int i = 0; i < n; i++){
            for (int j = 0; j < n; j++){
                if(grid[i][j] == 1){
                    //Add theif coords to queue
                    queue.Enqueue(new int[]{i,j});
                    tiles[i,j] = 0; // Add theif to tile (safety value for that space is 0)
                }
                else{
                    tiles[i,j] = -1; // Empty tile (-1 represents an unvisited tile for sake of getting each safety factor)
                }
            }
        }

        // Calc safety factor of each tile using BFS
        while (queue.Count > 0){
            int size = queue.Count;
            while (size-- > 0){
                int[] current = queue.Dequeue();
                // Check adjacent neighbouring tiles
                foreach (int[] dir in directions){
                    int i = current[0] + dir[0];
                    int j = current[1] + dir[1];
                    int val = tiles[current[0], current[1]];
                    // Check if is a valid cell on the grid and not yet visited (is -1)
                    if(i >= 0 && i < n && j >= 0 && j < n && tiles[i,j] == -1){
                        // Update safeness factor and push to queue
                        tiles[i,j] = val + 1; // Will equal the min number of steps from each thief
                        queue.Enqueue(new int[]{i,j});
                    }
                }
            }
        }

        int start = 0;
        int end = 0;
        int score = -1; // The Max Safety score

        // Get max potential safety score
        for (int i = 0; i < n; i++){
            for (int j = 0; j < n; j++){
                end = Math.Max(end, tiles[i,j]);
            }
        }

        // Binary search for maximum safeness factor
        while (start <= end){
            int mid = start + (end - start) / 2;
            if (ExistsValidPath(tiles, mid)){
                // Search for larger safeness values
                score = mid;
                start = mid + 1; 
            }
            else{
                end = mid - 1;
            }
        }

        return score;
    }
    
    // Takes in a safeness value and finds if there is a valid path of that safeness value
    public bool ExistsValidPath(int[,] tiles, int minSafeness){
        int n = tiles.GetLength(0);

        if (tiles[0, 0] < minSafeness || tiles[n-1, n-1] < minSafeness) return false; // Need beginning and end to be valid

        Queue<int[]> queue = new Queue<int[]>(); // Queue to handle traversing the grid
        bool[,] visited = new bool[n,n];

        // Start from [0,0]
        queue.Enqueue(new int[]{0,0});
        visited[0,0] = true;

        // BFS to find a valid path
        while (queue.Count > 0){
            int[] current = queue.Dequeue();
            if(current[0] == n-1 && current[1] == n-1){
                return true; // Valid path found
            }

            // Check neighbouring tiles
            foreach (int[] dir in directions){
                int i = current[0] + dir[0];
                int j = current[1] + dir[1];

                // Check if valid cell
                if (i >= 0 && i < n && j >= 0 && j < n && !visited[i,j] && tiles[i,j] >= minSafeness){
                    visited[i,j] = true;
                    queue.Enqueue(new int[]{i,j}); // Only enqueue valid and unvisited cells
                }
            }
        }
        return false; // No path has been found
    }
}