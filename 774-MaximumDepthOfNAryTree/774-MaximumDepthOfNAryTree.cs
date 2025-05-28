// Last updated: 28/05/2025, 13:16:06
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {

    int maxDepth = 0;

    public int MaxDepth(Node root) {
        DFS(root, 1);
        return maxDepth;
    }

    public void DFS(Node current, int depth)
    {
        if(current == null) return;

        maxDepth = Math.Max(maxDepth, depth);

        foreach (Node child in current.children)
        {
            DFS(child, depth + 1);
        }
    }
}