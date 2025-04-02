// Last updated: 02/04/2025, 17:05:29
public class Solution {
    public string DecodeString(string s) {
        Stack<int> nums = new Stack<int>();
        Stack<string> strings = new Stack<string>();

        string currentString = "";
        int currentNum = 0;
        foreach (char c in s)
        {
            if (c == '[')
            {
                strings.Push(currentString);
                nums.Push(currentNum);
                currentString = "";
                currentNum = 0;
            }
            else if (c == ']')
            {
                currentString = strings.Pop() + string.Join("", Enumerable.Repeat(currentString, nums.Pop()));
            }
            else if (char.IsDigit(c))
            {
                currentNum = currentNum * 10 + (c - '0');
            }
            else
            {
                currentString += c;
            }
        }

        return currentString;
    }
}