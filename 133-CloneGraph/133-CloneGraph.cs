/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        var clones = new Dictionary<Node, Node>();
        return Clone(node, clones);
    }

    public Node Clone(Node n, Dictionary<Node, Node> clones)
    {
        if (n == null) return null;

        if (clones.ContainsKey(n)) return clones[n]; // Skip over already cloned nodes

        clones[n] = new Node(n.val); // Create new Node

        // Clone the neighbours
        foreach (Node neighbor in n.neighbors)
        {
            clones[n].neighbors.Add(Clone(neighbor, clones));
        }

        return clones[n];
    }
}