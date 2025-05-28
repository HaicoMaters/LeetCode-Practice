// Last updated: 28/05/2025, 13:18:03
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
    public IList<int> PostorderTraversal(TreeNode root) {
        order = new List<int>();
        DFS(root);
        return order;
    }

    public void DFS(TreeNode current)
    {
        if (current == null) return;

        DFS(current.left);
        DFS(current.right);
        order.Add(current.val);
    }
}