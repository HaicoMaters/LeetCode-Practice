// Last updated: 10/06/2026, 10:32:44
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
15    public TreeNode TrimBST(TreeNode root, int low, int high) {
16        if (root == null) return null;
17
18        if (root.val > high) return TrimBST(root.left, low, high);
19        if (root.val < low) return TrimBST(root.right, low, high);
20
21        root.left = TrimBST(root.left, low, high);
22        root.right = TrimBST(root.right, low, high);
23
24        return root;
25    }
26}