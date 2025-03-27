// Last updated: 27/03/2025, 15:14:02
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
    int result = 0;

    public int KthSmallest(TreeNode root, int k) {
        DFS(root, k);
        return result;
    }

    private void DFS(TreeNode current, int k)
    {
        if (current == null || count >= k) return;

        DFS(current.left, k);
        count++;

        if (count == k)
        {
            result = current.val;
            return;
        }

        DFS(current.right, k);
    }
}