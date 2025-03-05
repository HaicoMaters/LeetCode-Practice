public class MinStack {

    Stack<(int val, int minVal)> stack; // Store the min value in the stack alongside each element

    public MinStack() {
        stack = new Stack<(int, int)>();
    }
    
    public void Push(int val) {
        int min = 0;
        if (stack.Count == 0)
        {
            min = val;
        }
        else
        {
            min = Math.Min(stack.Peek().minVal, val);
        }
        stack.Push((val, min));
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek().val;
    }
    
    public int GetMin() {
        return stack.Peek().minVal;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */