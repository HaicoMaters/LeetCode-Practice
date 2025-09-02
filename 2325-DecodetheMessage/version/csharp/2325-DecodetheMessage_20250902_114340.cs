// Last updated: 02/09/2025, 11:43:40
public class Solution {
    public string DecodeMessage(string key, string message) {
        Dictionary<char, char> substitutions = new Dictionary<char,char>();

        key = key.Replace(" ", ""); // remove whitespace

        char subLetter = 'a';
        foreach (char c in key)
        {
            if (!substitutions.ContainsKey(c))
            {
                substitutions[c] = subLetter++;
            }
        }

        StringBuilder decoded = new StringBuilder();

        foreach (char c in message)
        {
            if (c == ' ')
            {
                decoded.Append(' ');
            }
            else
            {
                decoded.Append(substitutions[c]);
            }
        }

        return decoded.ToString();
    }
}