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
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        return CheckSymmetry(root.left, root.right);
    }

    public bool CheckSymmetry(TreeNode currentL, TreeNode currentR)
    {
        if (currentL == null && currentR == null) return true;
        if (currentL == null || currentR == null) return false;

        return (currentL.val == currentR.val) && CheckSymmetry(currentL.left, currentR.right) 
        && CheckSymmetry(currentL.right, currentR.left);
    }
}