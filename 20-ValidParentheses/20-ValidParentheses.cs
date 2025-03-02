public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++) {
            switch (s[i]) {
                case '(': case '[': case '{':
                    stack.Push(s[i]);
                    break;
                case ')':
                    if (stack.Count == 0 || stack.Pop() != '(') {
                        return false;
                    }
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Pop() != '[') {
                        return false;
                    }
                    break;
                case '}':
                    if (stack.Count == 0 || stack.Pop() != '{') {
                        return false;
                    }
                    break;
            }
        }
        return stack.Count == 0;
    }
}
