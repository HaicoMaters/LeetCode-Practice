// Last updated: 28/05/2025, 13:16:16
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
    public IList<double> AverageOfLevels(TreeNode root) {
        Dictionary<int, (long sum, int frequency)> levels = new Dictionary<int, (long sum, int frequency)>();
        DFS(root, 0, levels);

        List<double> averages = new List<double>();
        for (int i = 0; i < levels.Count; i++) {
            double average = (double) levels[i].sum / levels[i].frequency;
            averages.Add(average);
        }

        return averages;
    }

    public void DFS(TreeNode current, int depth, Dictionary<int, (long sum, int frequency)> levels) {
        if (current == null) return;

        if (!levels.ContainsKey(depth)) {
            levels[depth] = ((long) current.val, 1);
        } else {
            var (sum, freq) = levels[depth];
            levels[depth] = (sum + current.val, freq + 1);
        }

        DFS(current.left, depth + 1, levels);
        DFS(current.right, depth + 1, levels);
    }
}