// Last updated: 28/05/2025, 13:16:22
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
    int sum = 0;
    public TreeNode ConvertBST(TreeNode root) {
        if (root == null) return null;

        ConvertBST(root.right); // Sum of right first 
        sum += root.val;
        root.val = sum;
        ConvertBST(root.left); // Sum of left last
        return root;
    }
}