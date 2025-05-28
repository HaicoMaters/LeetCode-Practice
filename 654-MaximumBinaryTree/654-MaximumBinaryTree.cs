// Last updated: 28/05/2025, 13:16:14
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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        return Construct(nums, 0, nums.Length-1);
    }

    public TreeNode Construct(int[] nums, int left, int right)
    {
        if (left > right) return null;
        int index = left;

        for (int i = left +1; i <= right; i++) // find the index of the max num
        {
            if (nums[i] > nums[index])
            {
                index = i;
            }
        }

        TreeNode root = new TreeNode(nums[index]);
        root.left = Construct(nums, left, index-1);
        root.right = Construct(nums, index + 1, right);

        return root;
    }
}