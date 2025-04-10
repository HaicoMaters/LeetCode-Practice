// Last updated: 10/04/2025, 17:54:16
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
    public List<IList<int>> order;

    public IList<IList<int>> LevelOrder(Node root) {
        order = new List<IList<int>>();
        Traverse(root, 1);
        return order;
    }

    public void Traverse(Node current, int depth)
    {
        if (current == null) return;

        if (order.Count < depth)
        {
            order.Add(new List<int>());
        }

        order[depth - 1].Add(current.val);

        foreach (Node child in current.children)
        {
            Traverse(child, depth + 1);
        }
    }
}