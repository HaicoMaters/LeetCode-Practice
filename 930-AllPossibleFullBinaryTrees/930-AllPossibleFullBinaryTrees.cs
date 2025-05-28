// Last updated: 28/05/2025, 13:15:52
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
    Dictionary<int, List<TreeNode>> memo = new Dictionary<int, List<TreeNode>>();
    public IList<TreeNode> AllPossibleFBT(int n) {

        if (!memo.ContainsKey(n)){
            List<TreeNode> list = new List<TreeNode>();
            if (n == 1){
                list.Add(new TreeNode(0));
            }
            else if (n % 2 == 1){ // Must be odd to be possible, 0 or 2 children + root
                for (int i = 1; i < n; i += 2){ // i starts at 1 and increments by 2 (only odd)
                    int j = n - 1 - i; // number of nodes in right subtree
                    foreach (TreeNode L in AllPossibleFBT(i)){
                        foreach (TreeNode R in AllPossibleFBT(j)){
                            TreeNode root = new TreeNode(0);
                            root.left = Copy(L);
                            root.right = Copy(R);
                            list.Add(root);
                        }
                    }
                }
            }
            memo[n] = list;
        }

        return memo[n];
    }

    public TreeNode Copy(TreeNode node){
        if (node == null) return null;
        TreeNode newNode = new TreeNode(node.val);
        newNode.left = Copy(node.left);
        newNode.right = Copy(node.right);
        return newNode;
    }
}