// Last updated: 12/08/2025, 13:16:38
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
    public TreeNode BstToGst(TreeNode root) {
        DFS(root, 0);
        return root;
    }

    public int DFS(TreeNode current, int sum)
    {
        if (current == null) return sum;

        sum = DFS(current.right, sum) + current.val; // BST so all to the right are greater
        current.val = sum;
        return DFS(current.left, sum);
    }
}