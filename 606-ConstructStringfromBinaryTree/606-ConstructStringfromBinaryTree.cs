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
    public string Tree2str(TreeNode root) {
        StringBuilder sb = new StringBuilder();
        DFS(root, sb);
        return sb.ToString();
    }

    public void DFS(TreeNode current, StringBuilder sb)
    {
        if (current == null) return;

        sb.Append(current.val);

        if (current.left != null || current.right != null){ // Still need an empty set of brackets if there is only right child
            sb.Append('(');
            DFS(current.left, sb);
            sb.Append(')');
        }

        if (current.right != null){
            sb.Append('(');
            DFS(current.right, sb);
            sb.Append(')');
        }
    }
}