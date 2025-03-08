/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {

        // Create a copy and insert it into the original (A -> copy of A -> B -> copy of B -> C...)
        Node current = head;
        while (current != null) {
            Node copy = new Node(current.val);
            copy.next = current.next;
            current.next = copy;
            current = copy.next;
        }

        // Assign the pointers for the copied nodes 
        current = head;
        while (current != null){
            // If uncopied random is null then the copied will have a null pointer
            if (current.random != null){
                // Give the next node (copied one) a pointer the the node after this nodes random pointer (the copy of the original random node)
                current.next.random = current.random.next;
            }
            current = current.next.next; // Get next uncopied node (skip over uncopied node)
        }

        // Construct copy list as just the copied nodes (every second node) and reconstruct the original list
        Node dummy = new Node(0);
        Node copyHead = dummy;
        current = head;
        while (current != null){
            Node copy = current.next;
            current.next = copy.next; // Reconstruct original list by removing copy nodes
            copyHead.next = copy; // Add copy to new list
            copyHead = copy;
            current = current.next;
        }

        return dummy.next;
    }
}