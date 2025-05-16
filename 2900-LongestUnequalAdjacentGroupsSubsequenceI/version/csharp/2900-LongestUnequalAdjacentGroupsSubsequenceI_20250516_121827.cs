// Last updated: 16/05/2025, 12:18:27
public class Solution {
    public IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups) {
        int n = groups.Length;

        List<string> subsequence = new List<string>();

        int[] dp = new int[n];
        int[] prev = new int[n];
        dp[0] = 1;
        prev[0] = -1;
        int maxIndex= 0;

        for (int i = 1; i < n; i++)
        {
            int maxLength = 1; 
            int prevIndexOfMaxLength = -1;
            for (int j = 0; j < i; j++)
            {
                if (words[i].Length != words[j].Length || groups[i] == groups[j]) continue;

                if (HammingDistanceIsOne(words[i], words[j]))
                {
                    if (dp[j] + 1 > maxLength)
                    {
                        maxLength = dp[j] + 1;
                        prevIndexOfMaxLength = j;
                    }
                }
            }
            dp[i] = maxLength;
            prev[i] = prevIndexOfMaxLength;

            if (dp[i] > dp[maxIndex]) maxIndex = i;
        }

        while (maxIndex >= 0)
        {
            subsequence.Add(words[maxIndex]);
            maxIndex = prev[maxIndex];
        }
        
        subsequence.Reverse();
        return subsequence;
    }

    bool HammingDistanceIsOne(string s1, string s2)
    {
        int dist = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i]) dist++;
            if (dist > 1) return false; // Terminate early if higher than one
        }

        return dist == 1;
    }
}