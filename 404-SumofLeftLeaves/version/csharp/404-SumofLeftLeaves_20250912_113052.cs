// Last updated: 12/09/2025, 11:30:52
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
    public int SumOfLeftLeaves(TreeNode root) {
        int sum = 0;
        DFS(root, ref sum);
        return sum;
    }

    public void DFS(TreeNode current, ref int sum)
    {
        if (current == null) return;

        if (current.left != null && current.left.left == null && current.left.right == null) sum += current.left.val;

        DFS(current.left, ref sum);
        DFS(current.right, ref sum);
    }
}