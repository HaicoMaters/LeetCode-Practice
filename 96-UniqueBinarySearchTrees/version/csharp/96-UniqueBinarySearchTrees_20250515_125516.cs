// Last updated: 15/05/2025, 12:55:16
public class Solution {
    public int NumTrees(int n) {
        int[] dp = new int [n+1];

        dp[0] = 1; // if n = 0; 1 tree (empty tree)
        dp[1] = 1; // if n = 1; 1 tree (single root)

        for (int i = 2; i <= n; i++) // try subtrees of each size with i as the root, and j as the node index
        {
            for (int j = 1; j <= i; j++)
            {
                // Left subtree, j-1, and right subtree is i-j
                dp[i] += dp[j-1] * dp[i-j]; 
            }
        }

        return dp[n];
    }
}