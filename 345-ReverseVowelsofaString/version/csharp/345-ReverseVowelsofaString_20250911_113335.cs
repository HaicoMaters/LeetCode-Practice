// Last updated: 11/09/2025, 11:33:35
public class Solution {
    public string ReverseVowels(string s) {
        HashSet<char> vowelSet = new HashSet<char>("AEIOUaeiou");
        List<char> vowels = new List<char>();

        foreach (char c in s)
        {
            if (vowelSet.Contains(c))
            {
                vowels.Add(c);
            }
        }

        char[] str = s.ToCharArray();
        int idx = vowels.Count - 1;

        for (int i = 0; i < str.Length; i++)
        {
            if (vowelSet.Contains(str[i]))
            {
                str[i] = vowels[idx--];
            }
        }

        return new string(str);
    }
}