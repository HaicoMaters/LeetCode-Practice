// Last updated: 21/08/2025, 12:26:37
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
    public TreeNode ReverseOddLevels(TreeNode root) {
        ReverseOdd(root.left, root.right, true); // the far left swaps with far right etc so traverse left and right child at same time
        return root;
    }

    public void ReverseOdd(TreeNode left, TreeNode right, bool isOdd)
    {
        if (left == null || right == null) return;

        if (isOdd)
        {
            int temp = left.val;
            left.val = right.val;
            right.val = temp;
        }

        ReverseOdd(left.left, right.right, !isOdd);
        ReverseOdd(left.right, right.left, !isOdd);
    }
}