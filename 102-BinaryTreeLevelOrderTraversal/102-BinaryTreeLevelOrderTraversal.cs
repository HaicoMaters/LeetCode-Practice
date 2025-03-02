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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> levelOrder = new List<IList<int>>();
        GetLeaf(root, 0, levelOrder);
        return levelOrder;
    }

    public void GetLeaf(TreeNode current, int depth, List<IList<int>> levelOrder)
    {
        if (current == null) return;
        if (levelOrder.Count <= depth) levelOrder.Add(new List<int>{current.val});
        else levelOrder[depth].Add(current.val);
        GetLeaf(current.left, depth + 1, levelOrder);
        GetLeaf(current.right, depth + 1, levelOrder);
    }
}