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
    public int MaxDepth(TreeNode root) {
        return GetMaxDepth(root, 0);
    }

    public int GetMaxDepth(TreeNode node, int depth)
    {
        if (node == null) return depth;
        return Math.Max(GetMaxDepth(node.left, depth + 1), GetMaxDepth(node.right, depth + 1));
    }
}