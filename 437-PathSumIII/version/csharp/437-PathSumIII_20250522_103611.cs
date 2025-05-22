// Last updated: 22/05/2025, 10:36:11
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution { // Optimized O(n) solution using prefix sum
    public int PathSum(TreeNode root, int targetSum) {
        var prefix = new Dictionary<long, int>(); // prefix sum -> count of occurrences
        prefix[0] = 1;
        return DFS(root, 0, targetSum, prefix);
    }

    private int DFS(TreeNode node, long currSum, int target, Dictionary<long, int> prefix) {
        if (node == null) return 0;

        currSum += node.val;

        int paths = 0;
        if (prefix.ContainsKey(currSum - target))
        {
            paths += prefix[currSum - target];
        }

        // Add current sum to prefix map
        if (!prefix.ContainsKey(currSum))
        {
            prefix[currSum] = 0;
        }
        prefix[currSum]++;

        paths += DFS(node.left, currSum, target, prefix);
        paths += DFS(node.right, currSum, target, prefix);

        // Remove current sum from map
        prefix[currSum]--;

        return paths;
    }
}