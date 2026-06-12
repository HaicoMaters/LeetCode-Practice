// Last updated: 12/06/2026, 09:33:47
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
19     // Serialized as (node,(leftSubtree),(rightSubtree)) with '-' exhibiting the ends of the subtrees
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
37
38    // Decodes your encoded data to tree.
39    public TreeNode deserialize(string data) {
40        if (string.IsNullOrEmpty(data)) return null; 
41        
42        string[] parts = data.Split(",");
43        int idx = 0;
44        TreeNode tree = BuildTree(parts, ref idx);
45        return tree;
46    }
47
48    public TreeNode BuildTree(string[] parts, ref int idx)
49    {
50        if (parts[idx] == "-")
51        {
52            idx++;
53            return null;
54        }
55
56        TreeNode current = new TreeNode(int.Parse(parts[idx]));
57        idx++;
58        current.left = BuildTree(parts, ref idx);
59        current.right = BuildTree(parts, ref idx);
60
61        return current;
62    }
63}
64
65// Your Codec object will be instantiated and called as such:
66// Codec ser = new Codec();
67// Codec deser = new Codec();
68// TreeNode ans = deser.deserialize(ser.serialize(root));