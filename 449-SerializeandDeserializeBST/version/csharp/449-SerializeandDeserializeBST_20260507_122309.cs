// Last updated: 07/05/2026, 12:23:09
1/**
2 * Definition for a binary tree node.
3 * public class TreeNode {
4 *     public int val;
5 *     public TreeNode left;
6 *     public TreeNode right;
7 *     public TreeNode(int x) { val = x; }
8 * }
9 */
10public class Codec {
11
12    // Encodes a tree to a single string.
13    public string serialize(TreeNode root) {
14        StringBuilder serial = new StringBuilder();
15        BuildStringDFS(root, serial);
16        return serial.ToString();
17    }
18
19    // Serialized as (node,(leftSubtree),(rightSubtree)) with '-' exhibiting the ends of the subtrees
20    public void BuildStringDFS(TreeNode current, StringBuilder sb)
21    {
22        if (current == null)
23        {
24            sb.Append("-");
25            return;
26        }
27
28        sb.Append(current.val);
29        
30        sb.Append(",");
31        BuildStringDFS(current.left, sb);
32        
33        sb.Append(",");
34        BuildStringDFS(current.right, sb);
35    }
36
37    // Decodes your encoded data to tree.
38    public TreeNode deserialize(string data) {
39        if (string.IsNullOrEmpty(data)) return null; 
40
41        string[] parts = data.Split(",");
42        int idx = 0;
43        TreeNode tree = BuildTree(parts, ref idx);
44        return tree;
45    }
46
47    public TreeNode BuildTree(string[] parts, ref int idx)
48    {
49        if (parts[idx] == "-")
50        {
51            idx++;
52            return null;
53        }
54
55        TreeNode current = new TreeNode(int.Parse(parts[idx]));
56        idx++;
57        current.left = BuildTree(parts, ref idx);
58        current.right = BuildTree(parts, ref idx);
59
60        return current;
61    }
62}
63
64// Your Codec object will be instantiated and called as such:
65// Codec ser = new Codec();
66// Codec deser = new Codec();
67// String tree = ser.serialize(root);
68// TreeNode ans = deser.deserialize(tree);
69// return ans;