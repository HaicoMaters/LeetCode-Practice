// Last updated: 21/08/2025, 12:42:17
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
    public TreeNode RecoverFromPreorder(string traversal) {
        List<TreeNode> levels = new List<TreeNode>(); // each level is the parent of the current node at the level above

        for (int i = 0; i < traversal.Length;)
        {
            int level = 0;
            while (traversal[i] == '-') // depth is the number of '-' before a number
            {
                i++;
                level++;
            }

            int val = 0;
            while (i < traversal.Length && traversal[i] != '-') // read the val (val*10 until the number ends for each digit)
            { 
                val = val * 10 + traversal[i++] - '0'; 
            }

            TreeNode node = new TreeNode(val);

            if (level < levels.Count) // Update the levels list for the current node
            { 
                levels[level] = node;
            }
            else
            {
                levels.Add(node);
            }

            if (level > 0) // connect the root to its parent
            {
                TreeNode parent = levels[level -1];
                if (parent.left != null)
                {
                    parent.right = node;
                }
                else
                {
                    parent.left = node;
                }
            }
        }
        return levels[0]; // the root
    }
}