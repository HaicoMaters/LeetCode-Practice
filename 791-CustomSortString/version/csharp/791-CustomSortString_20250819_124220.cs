// Last updated: 19/08/2025, 12:42:20
public class Solution {
    public string CustomSortString(string order, string s) {
        int[] chs = new int[26];

        foreach (char c in s)
        {
            chs[c - 'a']++;
        }

        StringBuilder sb = new StringBuilder();

        foreach (char c in order)
        {
            int index = c - 'a';
            while (chs[index] > 0)
            {
                chs[index]--;
                sb.Append(c);
            }
        }

        for (int i = 0 ; i < 26; i++)
        {
            char c = (char)(i + 'a');

            while (chs[i] > 0)
            {
                sb.Append(c);
                chs[i]--;
            }
        }

        return sb.ToString();
    }
}