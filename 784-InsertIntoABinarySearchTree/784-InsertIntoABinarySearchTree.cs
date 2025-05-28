// Last updated: 28/05/2025, 13:16:01
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
public class Solution{
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if (root == null) return new TreeNode(val);// Create new node if reach end of path

        if (root.val > val) {
            root.left = InsertIntoBST(root.left, val);
        } 

        else { // Question guarantees no duplicate values so else works here
            root.right = InsertIntoBST(root.right, val);
        }

        return root;
    }
}
