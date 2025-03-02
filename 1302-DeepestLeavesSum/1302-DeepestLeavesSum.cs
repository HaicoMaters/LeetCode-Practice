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
    int maxDepth = 0;

    public int DeepestLeavesSum(TreeNode root) {
        maxDepth = GetMaxDepth(root, 0);
        GetLeaf(root, 0);
        return sum;
    }

    // Recurisively find the max depth
    public int GetMaxDepth(TreeNode current, int depth)
    {
        maxDepth = depth;

        if(current.left != null) maxDepth = GetMaxDepth(current.left, depth + 1);
        if(current.right != null) maxDepth = Math.Max(maxDepth, GetMaxDepth(current.right, depth + 1));

        return maxDepth;
    }

    // Recursively get each node/leaf of the tree and add the value of the root if at max depth
    public void GetLeaf(TreeNode root, int depth)
    {
        if (root == null) return;

        if (root.right == null && root.left == null && depth == maxDepth) sum += root.val;
        else
        {
            GetLeaf(root.left, depth + 1);
            GetLeaf(root.right, depth + 1);
        }
    }
}