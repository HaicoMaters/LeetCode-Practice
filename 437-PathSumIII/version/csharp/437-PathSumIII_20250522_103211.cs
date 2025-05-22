// Last updated: 22/05/2025, 10:32:11
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
    int paths = 0;
    List<long> path;
    public int PathSum(TreeNode root, int targetSum) {
        path = new List<long>();
        DFS(root, targetSum);
        return paths;
    }

    public void DFS(TreeNode current, int target)
    {
        if (current == null) return;

        path.Add(current.val);

        // Check all subPaths, ending at current node for target sum
        long pathSum = 0;
        for (int i = path.Count -1; i >= 0; i--)
        {
            pathSum += path[i];
            if (pathSum == target) paths++;
        }

        DFS(current.left, target);
        DFS(current.right, target);
        path.RemoveAt(path.Count - 1);
    }
}