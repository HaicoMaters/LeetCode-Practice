// Last updated: 01/05/2026, 09:16:49
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
15    public TreeNode PruneTree(TreeNode root) {
16        bool tree = DFS(root);
17        if (!tree) return null;
18        return root;
19    }
20
21    public bool DFS(TreeNode current)
22    {
23        if (current == null) return false;
24
25        bool left = DFS(current.left);
26        if (!left) current.left = null;
27        bool right = DFS(current.right);
28        if (!right) current.right = null;
29
30        if (current.val == 1 || left || right) return true;
31        
32        return false;
33    }
34
35}