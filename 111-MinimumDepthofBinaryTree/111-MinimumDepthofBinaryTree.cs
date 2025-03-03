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
    public int MinDepth(TreeNode root) {
        if (root == null) return 0;

        int left = MinDepth(root.left);
        int right = MinDepth(root.right);

        if (left == 0 || right == 0) // Properly handle cases where there is one or no children
        {
            return Math.Max(left, right) + 1;
        }

        return Math.Min(left, right) + 1;
    }
}