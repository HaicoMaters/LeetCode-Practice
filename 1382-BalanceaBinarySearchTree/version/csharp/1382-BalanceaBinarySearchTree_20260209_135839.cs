// Last updated: 09/02/2026, 13:58:39
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
15    List<int> tree;
16    public TreeNode BalanceBST(TreeNode root) {
17        tree = new List<int>();
18        inOrder(root);
19        return buildTree(0, tree.Count-1);
20    }
21
22    public void inOrder(TreeNode node)
23    {
24        if (node == null) return;
25        inOrder(node.left);
26        tree.Add(node.val);
27        inOrder(node.right);
28    }
29
30    public TreeNode buildTree(int start, int end)
31    {
32        if (start > end) return null;
33        int mid = start + (end - start) / 2;
34        TreeNode root = new TreeNode(tree[mid]);
35        root.left = buildTree(start, mid-1);
36        root.right = buildTree(mid+1, end);
37        return root;
38    }
39}