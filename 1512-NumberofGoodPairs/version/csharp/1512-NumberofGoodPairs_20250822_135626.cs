// Last updated: 22/08/2025, 13:56:26
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int pairs = 0;

        Dictionary<int, int> freq = new Dictionary<int,int>();
        foreach (int num in nums)
        {
            if (!freq.ContainsKey(num))
            {
                freq[num] = 1;
            }
            else
            {
                pairs += freq[num];
                freq[num]++;
            }
        }

        return pairs; 
    }
}