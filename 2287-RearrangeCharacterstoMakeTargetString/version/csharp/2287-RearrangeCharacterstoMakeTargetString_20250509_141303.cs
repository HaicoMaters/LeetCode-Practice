// Last updated: 09/05/2025, 14:13:03
public class Solution {
    public int RearrangeCharacters(string s, string target) {
        int[] countS = new int[26];
        foreach (char c in s)
        {
            countS[c - 'a']++;
        }

        int[] countT = new int[26];
        foreach (char c in target)
        {
            countT[c - 'a']++;
        }

        int minPossible = int.MaxValue;

        for (int i = 0; i < 26; i++)
        {
            if (countT[i] == 0) continue;
            if (countS[i] == 0) return 0;

            minPossible = Math.Min(minPossible, countS[i] / countT[i]);
        }
        

        return minPossible;
    }
}