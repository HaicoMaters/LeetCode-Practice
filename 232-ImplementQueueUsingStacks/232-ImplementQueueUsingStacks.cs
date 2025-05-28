// Last updated: 28/05/2025, 13:17:41
public class MyQueue {

    // If one stack is empty keep using pop to get the stack in the
    // Reversed order
    Stack<int> stack;
    Stack<int> queue; 

    public MyQueue() {
        stack = new Stack<int>();
        queue = new Stack<int>();
    }
    
    public void Push(int x) {
        stack.Push(x);
    }
    
    public int Pop() {
        if (queue.Count == 0){
            TransferStackToQueue();
        }
        if (queue.Count == 0) throw new InvalidOperationException("Queue is empty.");

        return queue.Pop();
    }
    
    public int Peek() {
        if (queue.Count == 0){
            TransferStackToQueue();
        }
        if (queue.Count == 0) throw new InvalidOperationException("Queue is empty.");
        return queue.Peek();
    }
    
    public bool Empty() {
        return (queue.Count == 0 && stack.Count == 0);   
    }

    public void TransferStackToQueue(){
        while (stack.Count > 0){
                queue.Push(stack.Pop());
            }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */