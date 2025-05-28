// Last updated: 28/05/2025, 13:13:57
public class Solution {
    public int LengthAfterTransformations(string s, int t) {
        int mod = 1000000007;
        long[] counts = new long[26];

        foreach (char c in s)
        {
            counts[c - 'a']++;
        }

        while (t > 0)
        {
            long[] changed = new long[26];

            for (int i = 0; i< 26; i++)
            {
                if (i == 25) // z -> ab
                {
                    changed[0] = (changed[0] + counts[i]) % mod;
                    changed[1] = (changed[1] + counts[i]) % mod;
                }
                else // a-y -> b-z
                {
                    changed[i+1] = (changed[i+1] + counts[i]) % mod;
                }
            }
            counts = changed;
            t--;
        }

        long length = 0;
        foreach (long c in counts)
        {
            length = (length + c) % mod;
        }
        return (int) length;
    }
}