// Last updated: 29/04/2025, 16:03:16
public class Solution {
    List<IList<string>> palindromePartitions;
    public IList<IList<string>> Partition(string s) {
        palindromePartitions = new List<IList<string>>();
        BackTrack(s, new List<string>());
        return palindromePartitions;
    }

    public void BackTrack(string s, List<string> partition)
    {
        if (s == null || s.Length == 0)
        {
            palindromePartitions.Add(new List<string>(partition));
            return;
        }

        for (int i = 0; i < s.Length; i++)
        {
            string substring = s.Substring(0, i+1);

            if (!IsPalindrome(substring)) continue;

            partition.Add(substring);
            BackTrack(s.Substring(i+1, s.Length - (i + 1)), partition); // Continue with the rest of string not included in substring
            partition.RemoveAt(partition.Count - 1);
        }
    }

    public bool IsPalindrome(string s)
    {
        int index = s.Length -1;

        for (int i = 0; i < s.Length/2; i++)
        {
            if(s[i] != s[index]) return false;
            index--;
        }
        return true;
    }
}