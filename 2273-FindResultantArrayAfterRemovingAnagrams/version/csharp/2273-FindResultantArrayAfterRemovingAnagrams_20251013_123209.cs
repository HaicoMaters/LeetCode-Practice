// Last updated: 13/10/2025, 12:32:09
public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
        List<string> res = new List<string>();
        res.Add(words[0]);

        for (int i = 1; i < words.Length; i++)
        {
            if (!AreAnagram(words[i], words[i-1]))
            {
                res.Add(words[i]);
            }
        }

        return res;
    }

    bool AreAnagram(string a, string b)
    {
        if (a.Length != b.Length) return false;

        int[] letters = new int[26];

        for (int i = 0; i < a.Length; i++)
        {
            letters[a[i] - 'a']++;
            letters[b[i] - 'a']--;
        }

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] != 0) return false;
        }

        return true;
    }
}