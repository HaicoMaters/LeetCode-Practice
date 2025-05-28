// Last updated: 28/05/2025, 13:18:05
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
    List<int> order;
    public IList<int> PreorderTraversal(TreeNode root) {
        order = new List<int>();
        DFS(root);
        return order;
    }

    public void DFS(TreeNode current)
    {
        if (current == null) return;

        order.Add(current.val);
        DFS(current.left);
        DFS(current.right);
    }
}