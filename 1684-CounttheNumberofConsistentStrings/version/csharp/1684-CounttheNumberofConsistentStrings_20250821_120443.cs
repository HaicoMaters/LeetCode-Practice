// Last updated: 21/08/2025, 12:04:43
public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        HashSet<char> validChars = new HashSet<char>();

        int invalidStrings = 0;

        foreach (char c in allowed)
        {
            validChars.Add(c);
        }

        foreach (string word in words)
        {
            foreach (char c in word)
            {
                if (!validChars.Contains(c))
                {
                    invalidStrings++;
                    break;
                }
            }
        }

        return words.Length - invalidStrings;
    }
}