// Last updated: 27/08/2025, 12:19:41
public class Solution {
    int maxCount = 0;
    public int MaxUniqueSplit(string s) {
        SplitSubstrings(s, 0, new HashSet<string>(), 0);
        return maxCount;
    }

    public void SplitSubstrings(string s, int start, HashSet<string> uniqueSubstrings, int count)
    {
        if (count + (s.Length - start) <= maxCount) return; // Pruning: terminate early if is impossible to exceed maxCount mathematically

        if (start == s.Length)
        {
            maxCount = Math.Max(maxCount, count);
            return;
        }

        for (int end = start + 1; end <= s.Length; end++)
        {
            string substring = s.Substring(start, end - start);

            if (!uniqueSubstrings.Contains(substring))
            {
                uniqueSubstrings.Add(substring);

                SplitSubstrings(s, end, uniqueSubstrings, count+1);
                
                uniqueSubstrings.Remove(substring);
            }
        }
    }
}