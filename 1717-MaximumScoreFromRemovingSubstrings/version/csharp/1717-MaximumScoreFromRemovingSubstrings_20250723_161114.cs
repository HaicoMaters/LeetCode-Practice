// Last updated: 23/07/2025, 16:11:14
public class Solution {
    public int MaximumGain(string s, int x, int y) {

        if (x > y) // prioritize 'ab' over 'ba'
        {
            return CalcGain('a', 'b', x, y, s);
        }

        return CalcGain('b', 'a', y, x, s);
    }

    public int CalcGain(char one, char two, int x, int y, string s) // x should be larger than y and correspond with pattern (one,two)
    {
        Stack<char> forward = new Stack<char>();

        int gain = 0;
        foreach (char c in s) // get all pattern (one,two) and remove when building the stack of chars (x > y)
        {
            if (c == two && forward.Any() && forward.Peek() == one)
            {
                gain += x;
                forward.Pop();
                continue;
            }
            forward.Push(c);
        }

        Stack<char> reverse = new Stack<char>();
        while(forward.Any()) // from remaining chars find pattern (two,one) and get score from that
        {
            char c = forward.Pop();
            if (c == two && reverse.Any() && reverse.Peek() == one)
            {
                gain += y;
                reverse.Pop();
                continue;
            }
            reverse.Push(c);
        }

        return gain;
    }
}