// Last updated: 06/11/2025, 12:10:15
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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0 || inorder.Length == 0) return null;

        TreeNode root = new TreeNode(preorder[0]);
        int midIdx = Array.IndexOf(inorder, preorder[0]); 

        root.left = BuildTree(preorder[1..(Index)(midIdx+1)], inorder[0..midIdx]);
        root.right = BuildTree(preorder[(Index)(midIdx + 1)..], inorder[(Index)(midIdx + 1)..]);
        
        return root;
    }
}