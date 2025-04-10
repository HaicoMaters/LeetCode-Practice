// Last updated: 10/04/2025, 17:40:53
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    List<int> order;
    
    public IList<int> Preorder(Node root) {
        order = new List<int>();
        Traverse(root);
        return order;
    }

    public void Traverse(Node current)
    {
        if (current == null) return;

        order.Add(current.val);

        foreach (Node child in current.children)
        {
            Traverse(child);
        }
    }
}