// Last updated: 24/10/2025, 11:39:17
public class Solution {
    public int NextBeautifulNumber(int n) {
        int x = n + 1;

        while (x < int.MaxValue && !IsBalanced(x))
        {
            x++;
        }

        return x;

    }

    public bool IsBalanced(int x)
    {
        if (x == 0) return false;
        Dictionary<int, int> freq = new Dictionary<int,int>();
        
        while (x > 0)
        {
            int d = x % 10;
            x = x / 10;

            if (!freq.ContainsKey(d))
            {
                freq[d] = 0;
            }
            freq[d]++;
        }

        foreach (var kvp in freq)
        {
            if (kvp.Key != kvp.Value) return false;
        }

        return true;
    }
}