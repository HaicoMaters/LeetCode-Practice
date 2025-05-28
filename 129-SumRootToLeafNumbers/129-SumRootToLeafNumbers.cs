// Last updated: 28/05/2025, 13:18:09
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
    public int SumNumbers(TreeNode root) {
        return Sum(root, 0);
    }

    public int Sum(TreeNode current, int val)
    {
        if (current == null) return 0;

        val *= 10;
        val += current.val;

        if (current.left == null && current.right == null) {
            return val;
        }

        return Sum(current.left, val) + Sum(current.right, val);
    }
}