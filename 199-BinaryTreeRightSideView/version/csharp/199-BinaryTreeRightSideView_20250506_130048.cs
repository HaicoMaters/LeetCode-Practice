// Last updated: 06/05/2025, 13:00:48
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
    List<int> visibleNodes;
    public IList<int> RightSideView(TreeNode root) {
        visibleNodes = new List<int>();
        DFS(root, 1);
        return visibleNodes;
    }

    public void DFS(TreeNode current, int depth)
    {
        if (current == null) return;
        
        if (visibleNodes.Count < depth)
        {
            visibleNodes.Add(current.val);
        }

        DFS(current.right, depth + 1);
        DFS(current.left, depth + 1);
    }
}