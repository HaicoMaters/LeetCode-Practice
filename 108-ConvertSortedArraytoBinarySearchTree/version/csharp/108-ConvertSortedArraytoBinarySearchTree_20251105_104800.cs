// Last updated: 05/11/2025, 10:48:00
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
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums.Length <= 0) return null;

        int mid = nums.Length / 2;
        TreeNode treeRoot = new TreeNode(nums[mid]);

        treeRoot.left = SortedArrayToBST(nums[..mid]);
        treeRoot.right = SortedArrayToBST(nums[(mid+1)..]);

        return treeRoot;
    }
}