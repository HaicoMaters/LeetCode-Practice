// Last updated: 11/04/2025, 15:50:37
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    List<List<Node>> nodeDepths;

    public Node Connect(Node root) {
        nodeDepths = new List<List<Node>>(); 
        GetAllNodeDepths(root, 1);

        for (int i = 0; i < nodeDepths.Count - 1; i++) // Last will just be bunch of null nodes with current setup so should skip
        {
            for (int j = 0; j < nodeDepths[i].Count - 1; j++) // Skip final node next will always be null
            {
                Node current = nodeDepths[i][j];
                if (current != null)
                {
                    current.next = nodeDepths[i][j+1];
                }
            }
        }

        return root;
    }

    public void GetAllNodeDepths(Node current, int depth)
    {
        if (nodeDepths.Count < depth) // Last List will be skipped over
        {
            nodeDepths.Add(new List<Node>());
        }

        nodeDepths[depth - 1].Add(current); // should be added even if null

        if (current == null) 
        {
            return;
        }

        GetAllNodeDepths(current.left, depth + 1);
        GetAllNodeDepths(current.right, depth + 1);
    }
}