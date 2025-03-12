/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class BSTIterator {

    Queue<int> values;
    public BSTIterator(TreeNode root) {
        values = new Queue<int>();
        DFS(root);
    }

    public void DFS(TreeNode root){
        if (root == null) return;
        DFS(root.left);
        values.Enqueue(root.val);
        DFS(root.right);
    }
    
    public int Next() {
        return values.Dequeue();
    }
    
    public bool HasNext() {
        return values.Count != 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */