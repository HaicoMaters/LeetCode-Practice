// Last updated: 28/05/2025, 13:16:47
public class Solution {
    public int FirstUniqChar(string s) {
        var chars = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if(!chars.ContainsKey(c))
            {
                chars.Add(c, 1);
            }
            else
            {
                chars[c]++;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if(chars[s[i]] == 1) return i;
        }
        
        return -1;
    }
}