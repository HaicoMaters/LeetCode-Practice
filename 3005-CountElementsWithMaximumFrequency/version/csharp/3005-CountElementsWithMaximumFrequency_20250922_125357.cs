// Last updated: 22/09/2025, 12:53:57
public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        Dictionary<int,int> freq = new Dictionary<int,int>();
        int count = 0;
        int maxFreq = 0;

        foreach (int num in nums)
        {
            if (!freq.ContainsKey(num))
            {
                freq[num] = 0;
            }
            freq[num]++;
        }

        foreach (var kvp in freq)
        {
            if (kvp.Value == maxFreq)
            {
                count++;
            }
            if (kvp.Value > maxFreq)
            {
                maxFreq = kvp.Value;
                count = 1;
            }
        }

        return maxFreq * count;
    }
}