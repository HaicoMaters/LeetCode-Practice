// Last updated: 06/01/2026, 14:26:11
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
15    Dictionary<int, int> levelSum = new Dictionary<int, int>();
16
17    public int MaxLevelSum(TreeNode root) {
18        TraverseTree(root, 1);
19
20        int minKey = int.MaxValue;
21        int maxValue = int.MinValue;
22
23        foreach (var kvp in levelSum) {
24            if (kvp.Value > maxValue) {
25                maxValue = kvp.Value;
26                minKey = kvp.Key;
27            } 
28            else if (kvp.Value == maxValue) {
29                minKey = Math.Min(minKey, kvp.Key);
30            }
31        }
32
33        return minKey;
34    }
35
36    public void TraverseTree(TreeNode current, int depth){
37        if (current == null) return;
38
39        if (levelSum.ContainsKey(depth)){
40            levelSum[depth] += current.val;
41        }
42        else{
43            levelSum.Add(depth, current.val);
44        }
45
46        TraverseTree(current.left, depth+1);
47        TraverseTree(current.right, depth+1);
48    }
49}