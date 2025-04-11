// Last updated: 11/04/2025, 16:57:18
/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() {
        val = false;
        isLeaf = false;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val, bool _isLeaf) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}
*/

public class Solution {
    Dictionary<Node, (int top, int left, int bottom, int right)> nodeDimensions; 

    public Node Construct(int[][] grid) {
        int top = 0, left = 0, bottom = grid.Length - 1, right = grid[0].Length - 1;        // Original subgrid values
        nodeDimensions = new Dictionary<Node, (int top, int left, int bottom, int right)>();

        (bool isLeaf, bool val) = SubGridIsLeaf(top, left, bottom, right, grid);

        Node root = new Node(val, isLeaf);

        if (root.isLeaf) return root;

        nodeDimensions[root] = (top, left, bottom, right);

        ConstructQuadTree(root, grid);

        return root;
    }

    public void ConstructQuadTree(Node current, int[][] grid)
    {
        var dimensions = nodeDimensions[current];
        var subgrids = GetSubgrids(dimensions.top, dimensions.left, dimensions.bottom, dimensions.right);

        // Top-left (always present)
        var sg0 = subgrids[0].Value;
        (bool isLeaf, bool val) = SubGridIsLeaf(sg0.top, sg0.left, sg0.bottom, sg0.right, grid);
        Node topLeft = new Node(val, isLeaf);
        current.topLeft = topLeft;

        if (!isLeaf)
        {
            nodeDimensions[topLeft] = (sg0.top, sg0.left, sg0.bottom, sg0.right);
            ConstructQuadTree(topLeft, grid);
        }

        // Top-right
        if (subgrids[1] != null)
        {
            var sg1 = subgrids[1].Value;
            (isLeaf, val) = SubGridIsLeaf(sg1.top, sg1.left, sg1.bottom, sg1.right, grid);
            Node topRight = new Node(val, isLeaf);
            current.topRight = topRight;

            if (!isLeaf)
            {
                nodeDimensions[topRight] = (sg1.top, sg1.left, sg1.bottom, sg1.right);
                ConstructQuadTree(topRight, grid);
            }
        }

        // Bottom-left
        if (subgrids[2] != null)
        {
            var sg2 = subgrids[2].Value;
            (isLeaf, val) = SubGridIsLeaf(sg2.top, sg2.left, sg2.bottom, sg2.right, grid);
            Node bottomLeft = new Node(val, isLeaf);
            current.bottomLeft = bottomLeft;

            if (!isLeaf)
            {
                nodeDimensions[bottomLeft] = (sg2.top, sg2.left, sg2.bottom, sg2.right);
                ConstructQuadTree(bottomLeft, grid);
            }
        }

        // Bottom-right
        if (subgrids[3] != null)
        {
            var sg3 = subgrids[3].Value;
            (isLeaf, val) = SubGridIsLeaf(sg3.top, sg3.left, sg3.bottom, sg3.right, grid);
            Node bottomRight = new Node(val, isLeaf);
            current.bottomRight = bottomRight;

            if (!isLeaf)
            {
                nodeDimensions[bottomRight] = (sg3.top, sg3.left, sg3.bottom, sg3.right);
                ConstructQuadTree(bottomRight, grid);
            }
        }
    }


    // (Bottom will be a larger number than top just due to how the grid is setup)
    public (bool isLeaf, bool val) SubGridIsLeaf(int top, int left, int bottom, int right, int[][] grid)
    {
        int expectedVal = grid[top][left];

        for (int i = top; i <= bottom; i++)
        {
            for (int j = left; j <= right; j++)
            {
                if (grid[i][j] != expectedVal) return (false, true); // there will be at least a single 1 in there if it fails
            }
        }

        return (true, expectedVal == 1);
    }

    // returns in order of subgrids, top left, top right, bottom left, bottom right
    public List<(int top, int left, int bottom, int right)?> GetSubgrids(int _top, int _left, int _bottom, int _right) 
    {
        var subGrids = new List<(int top, int left, int bottom, int right)?>();

        int midWidth = _left + (_right - _left)/2;
        int midHeight= _top + (_bottom - _top)/2;

        // Add top left
        subGrids.Add((_top, _left, midHeight, midWidth));

        // Add top right
        if (_left != _right) // make so works when only 1 cell wide
        {
            subGrids.Add((_top, midWidth + 1, midHeight, _right));
        }
        else
        {
            subGrids.Add(null);
        }

        // Add bottom left
        if (_top != _bottom) // make so works when only 1 cell tall
        {
            subGrids.Add((midHeight + 1, _left, _bottom, midWidth));
        }
        else
        {
            subGrids.Add(null);
        }

        // Add bottom right
        if (_top != _bottom && _left != _right) // make so works when only 1 cell tall or 1 cell wide
        {
            subGrids.Add((midHeight + 1, midWidth + 1, _bottom, _right));
        }
        else
        {
            subGrids.Add(null);
        }

        return subGrids;
    }
}