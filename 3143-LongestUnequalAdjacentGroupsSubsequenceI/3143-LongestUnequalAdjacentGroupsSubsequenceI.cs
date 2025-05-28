// Last updated: 28/05/2025, 13:14:10
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