// Last updated: 29/07/2025, 12:14:41
public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> freq = new Dictionary<char,int>();

        if (s.Length != t.Length) return false;

        foreach (char c in s)
        {
            if (!freq.ContainsKey(c))
            {
                freq[c] = 0;
            }
            freq[c]++;
        }

        foreach (char c in t)
        {
            if (!freq.ContainsKey(c) || freq[c] == 0) return false;
            freq[c]--;
        }

        return true;
    }
}