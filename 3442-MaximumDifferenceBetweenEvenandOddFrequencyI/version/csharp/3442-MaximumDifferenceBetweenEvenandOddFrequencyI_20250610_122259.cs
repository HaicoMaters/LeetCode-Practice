// Last updated: 10/06/2025, 12:22:59
public class Solution {
    public int MaxDifference(string s) {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (!freq.ContainsKey(c))
            {
                freq[c] = 0;
            }
            freq[c]++;
        }

        int maxOdd = 0;
        int minEven = int.MaxValue;

        foreach (int x in freq.Values)
        {
            if (x % 2 == 0)
            {
                minEven = Math.Min(minEven, x);
            }
            else
            {
                maxOdd = Math.Max(maxOdd, x);
            }
        }

        return maxOdd - minEven;
    }
}