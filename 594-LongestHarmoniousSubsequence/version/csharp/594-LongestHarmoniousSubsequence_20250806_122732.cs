// Last updated: 06/08/2025, 12:27:32
public class Solution {
    public int FindLHS(int[] nums) {
        Dictionary<int,int> freq = new Dictionary<int,int>();
        int longestSubsequence = 0;

        foreach (int num in nums)
        {
            if (!freq.ContainsKey(num))
            {
                freq[num] = 0;
            }
            freq[num]++;
        }

        foreach (int num in freq.Keys)
        {
            if (freq.ContainsKey(num+1))
            {
                longestSubsequence = Math.Max(longestSubsequence, freq[num]  + freq[num+1]);
            }
        }

        return longestSubsequence;
    }
}