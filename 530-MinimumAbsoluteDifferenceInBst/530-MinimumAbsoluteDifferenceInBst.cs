// Last updated: 28/05/2025, 13:16:24
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
public class Solution {
    int minDiff = int.MaxValue;
    TreeNode prev = null;
    public int GetMinimumDifference(TreeNode root) {
        DFS(root);
        return minDiff;
    }

    public void DFS(TreeNode current)
    {
        if (current == null) return;

        DFS(current.left);
        if (prev != null) minDiff = (Math.Min(minDiff, current.val - prev.val));
        prev = current;
        DFS(current.right);
    }
}