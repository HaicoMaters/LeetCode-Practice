// Last updated: 21/10/2025, 11:56:48
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
    public bool IsValidBST(TreeNode root) {
        return IsBST(root, long.MinValue, long.MaxValue);
    }

    public bool IsBST(TreeNode current, long min, long max)
    {
        if (current == null) return true;

        if (current.val <= min || current.val >= max) return false;

        return IsBST(current.left, min, current.val) && IsBST(current.right, current.val, max);
    }
}