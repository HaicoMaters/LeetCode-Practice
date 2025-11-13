// Last updated: 13/11/2025, 12:24:02
public class Solution {
    public int MaxOperations(string s) {
        int ops = 0;
        int curr = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                curr++;
            }
            else if (s[i] == '0')
            {
                while (i < s.Length && s[i] == '0')
                {
                    i++;
                }
                i--;
                ops += curr;
            }
        }

        return ops;
    }
}