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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var order = new List<IList<int>>();
        if (root == null) return order;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool leftToRight = true;  // Track the direction

        while (queue.Count > 0) 
        {
            int levelSize = queue.Count;
            var level = new List<int>();

            for (int i = 0; i < levelSize; i++) 
            {
                var node = queue.Dequeue();
                
                // Add normally or at the front based on direction
                if (leftToRight) 
                {
                    level.Add(node.val);
                } 
                else 
                {
                    level.Insert(0, node.val); // Put to front if right to left
                }

                // Enqueue children for next level
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }

            order.Add(level);
            leftToRight = !leftToRight; // Flip direction
        }

        return order;
    }
}