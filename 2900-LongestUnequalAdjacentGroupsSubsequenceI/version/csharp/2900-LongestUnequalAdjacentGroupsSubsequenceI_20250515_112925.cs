// Last updated: 15/05/2025, 11:29:25
public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        int n = groups.Length;
        List<string> subsequence = new List<string>();

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || groups[i] != groups[i-1])
            {
                subsequence.Add(words[i]);
            }
        }
        return subsequence;
    }
}