// Last updated: 18/05/2026, 11:33:03
1/**
2 * Definition for a binary tree node.
3 * public class TreeNode {
4 *     public int val;
5 *     public TreeNode left;
6 *     public TreeNode right;
7 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
8 *         this.val = val;
9 *         this.left = left;
10 *         this.right = right;
11 *     }
12 * }
13 */
14public class Solution {
15    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
16        if (root1 == null) return root2;
17        if (root2 == null) return root1;
18
19        root1.val += root2.val;
20
21        root1.left = MergeTrees(root1.left, root2.left);
22        root1.right = MergeTrees(root1.right, root2.right);
23
24        return root1;
25    }
26}