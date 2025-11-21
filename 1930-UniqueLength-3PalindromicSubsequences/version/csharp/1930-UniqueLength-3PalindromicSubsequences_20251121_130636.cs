// Last updated: 21/11/2025, 13:06:36
public class Solution {
    public int CountPalindromicSubsequence(string s) {
        int count = 0;
        int n = s.Length;
        // first and last indexes of each char
        int[] first = new int[26];
        int[] last = new int[26];

        for (int i = 0; i < 26; i++)
        {
            first[i] = -1;
            last[i] = -1;
        }
        
        for (int i = 0; i < n; i++)
        {
            char c = s[i];
            if (first[c - 'a'] == -1) first[c - 'a'] = i;
            last[c - 'a'] = i;
        }


        for (int i = 0; i < 26; i++)
        {
            bool[] seen = new bool[26];
            if (first[i] != -1 && last[i] - first[i] > 1) // min two places away
            {
                for (int j = first[i] + 1; j < last[i]; j++)
                {
                    if (!seen[s[j] - 'a'])
                    {
                        count++;
                        seen[s[j] - 'a'] = true;
                    }
                }
            }
        }

        return count;
    }
}