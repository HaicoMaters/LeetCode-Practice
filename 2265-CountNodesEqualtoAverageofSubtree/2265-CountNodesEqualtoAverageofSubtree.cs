// Last updated: 24/03/2025, 13:47:29
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
    int count = 0;

    public int AverageOfSubtree(TreeNode root) {
        UpdateSubTreeCount(root);
        return count;
    }

    public (int sum, int nodeCount) UpdateSubTreeCount(TreeNode current){
        if (current == null){
            return (0, 0);
        }

        var left = UpdateSubTreeCount(current.left);
        var right = UpdateSubTreeCount(current.right);

        int currentSum = left.sum + right.sum + current.val;
        int currentCount = left.nodeCount + right.nodeCount + 1;

        if ((currentSum / currentCount) == current.val){
            count++;
        }

        return (currentSum, currentCount);
    }
}