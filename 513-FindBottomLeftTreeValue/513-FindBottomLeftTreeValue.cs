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

    int maxDepth = -1;
    int leftmostValue = -1;

    public int FindBottomLeftValue(TreeNode root) {
        DFS(root, 0);
        return leftmostValue;
    }

    private void DFS(TreeNode current, int depth) {
        if (current == null) {
            return;
        }

        // Update leftmostValue and maxDepth when encountering a deeper level
        if (depth > maxDepth) {
            leftmostValue = current.val;
            maxDepth = depth;
        }

        DFS(current.left, depth + 1);
        DFS(current.right, depth + 1);
    }
}