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
    public void Flatten(TreeNode root) {
        if (root == null) return;

        var nodes = new Stack<TreeNode>();
        nodes.Push(root);
        TreeNode prev = null; // Keep track of previous node

        while (nodes.Count > 0) {
            var current = nodes.Pop();

            // Attach previous node right pointer to the current node
            if (prev != null) {
                prev.right = current;
                prev.left = null;
            }

            // Push right first, then left (so left is processed first)
            if (current.right != null) nodes.Push(current.right);
            if (current.left != null) nodes.Push(current.left);

            prev = current;
        }
    }
}
