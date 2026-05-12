// Last updated: 12/05/2026, 12:54:16
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
15    TreeNode dummy = new TreeNode(0);
16    TreeNode current;
17
18    public TreeNode IncreasingBST(TreeNode root) {
19        current = dummy;
20        Inorder(root);
21        return dummy.right;
22    }
23
24    private void Inorder(TreeNode node)
25    {
26        if (node == null) return;
27
28        Inorder(node.left);
29
30        node.left = null;
31        current.right = node;
32        current = node;
33
34        Inorder(node.right);
35    }
36}