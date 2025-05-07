// Last updated: 07/05/2025, 12:11:29
public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<char, string> patternValues = new Dictionary<char, string>();
        HashSet<string> used = new HashSet<string>();
        string[] parts = s.Split(' ');

        if (parts.Length != pattern.Length) return false;

        for (int i = 0; i < parts.Length; i++)
        {
            if (patternValues.ContainsKey(pattern[i]))
            {
                if (parts[i] != patternValues[pattern[i]]) return false;
            }
            else
            {
                if (used.Contains(parts[i])) return false;

                patternValues[pattern[i]] = parts[i];
                used.Add(parts[i]);
            }
        }

        return true;
    }
}