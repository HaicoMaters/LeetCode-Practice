// Last updated: 28/05/2025, 13:15:45
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
    Dictionary<int, int> levelSum = new Dictionary<int, int>();

    public int MaxLevelSum(TreeNode root) {
        TraverseTree(root, 1);

        int minKey = int.MaxValue;
        int maxValue = int.MinValue;

        foreach (var kvp in levelSum) {
            if (kvp.Value > maxValue) {
                maxValue = kvp.Value;
                minKey = kvp.Key;
            } 
            else if (kvp.Value == maxValue) {
                minKey = Math.Min(minKey, kvp.Key);
            }
        }

        return minKey;
    }

    public void TraverseTree(TreeNode current, int depth){
        if (current == null) return;

        if (levelSum.ContainsKey(depth)){
            levelSum[depth] += current.val;
        }
        else{
            levelSum.Add(depth, current.val);
        }

        TraverseTree(current.left, depth+1);
        TraverseTree(current.right, depth+1);
    }
}