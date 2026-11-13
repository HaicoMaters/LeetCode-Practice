// Last updated: 13/11/2026, 09:33:53
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
15    public int i = 0;
16
17    public TreeNode BstFromPreorder(int[] preorder) {
18        return Build(preorder, int.MaxValue);
19    }
20
21    public TreeNode Build(int[] preorder, int maxAllowedValue) // max allowed value -> the max value there can be on this side of the root
22    {
23        if (i == preorder.Length || preorder[i] > maxAllowedValue) return null;
24
25        TreeNode root = new TreeNode(preorder[i++]);
26        root.left = Build(preorder, root.val);
27        root.right = Build(preorder, maxAllowedValue);
28
29        return root;
30    }
31}