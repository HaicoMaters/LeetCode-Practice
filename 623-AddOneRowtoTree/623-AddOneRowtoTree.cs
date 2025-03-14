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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        
        if (depth == 1) {
            TreeNode newRoot = new TreeNode(val);
            newRoot.left = root;
            return newRoot;
        }

        DFS(root, val, depth, 1);
        return root;
    }

    public void DFS(TreeNode current, int val, int insertDepth, int currentDepth) {
        if (current == null) return;

        if (currentDepth == insertDepth - 1) {
            TreeNode newLeft = new TreeNode(val);
            TreeNode newRight = new TreeNode(val);

            newLeft.left = current.left;
            newRight.right = current.right;
            current.left = newLeft;
            current.right = newRight;
            return;
        }

        DFS(current.left, val, insertDepth, currentDepth + 1);
        DFS(current.right, val, insertDepth, currentDepth + 1);
    }
}