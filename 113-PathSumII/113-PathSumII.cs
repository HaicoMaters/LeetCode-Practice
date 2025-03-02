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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        var paths = new List<IList<int>>();
        PathSum(root, targetSum, new List<int>(), paths);
        return paths;
    }

    public void PathSum(TreeNode current, int targetSum, List<int> path, List<IList<int>> paths)
    {
        if(current == null) return;

        targetSum -= current.val;
        path.Add(current.val);
        if (targetSum == 0 && current.left == null && current.right == null)
        {
            paths.Add(new List<int>(path));
        }
        else
        {
            PathSum(current.left, targetSum, path, paths);
            PathSum(current.right, targetSum, path, paths);
        }
        path.RemoveAt(path.Count - 1);
    }
}