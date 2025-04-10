// Last updated: 10/04/2025, 17:43:32
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
    public List<int> order;
    
    public IList<int> Postorder(Node root) {
        order = new List<int>();
        Traverse(root);
        return order;
    }

    public void Traverse(Node current){
        if (current == null) return;

        foreach (Node child in current.children)
        {
            Traverse(child);
        }

        order.Add(current.val);
    }
}