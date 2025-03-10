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
    List<string> paths = new List<string>();
    public IList<string> BinaryTreePaths(TreeNode root) {
        DFS(root, $"{root.val}");
        return paths;
    }

    public void DFS(TreeNode current, string str){
        if (current == null) return;

        if (current.left == null && current.right == null){
            paths.Add(str);
            return;
        }

        if (current.left != null) DFS(current.left, str + $"->{current.left.val}");
        if (current.right != null) DFS(current.right, str + $"->{current.right.val}");
    }
}