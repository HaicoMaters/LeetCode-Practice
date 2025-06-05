// Last updated: 05/06/2025, 11:15:23
public class Solution {
    public string SmallestEquivalentString(string s1, string s2, string baseStr) {

        int n = s1.Length;

        int[] parent = new int[26]; // index for char is char - 'a'

        for (int i = 0; i < 26; i++)
        {
            parent[i] = i;
        }

        for (int i = 0; i < n; i++) // Union for all of the chars in s1 and s2
        {
            int u = s1[i] - 'a';
            int v = s2[i] - 'a';

            int rootU = Find(parent, u);
            int rootV = Find(parent, v);
            
            // Make it so the parent is the lexicographically smallest parent
            parent[Math.Max(rootU, rootV)] = Math.Min(rootU, rootV);
        }

        StringBuilder sb = new StringBuilder();
        // get the smallest lexicographical string for basestr
        foreach (char c in baseStr)
        {
            sb.Append((char)(Find(parent, c - 'a') + 'a'));
        }

        return sb.ToString();
    }

    public int Find(int[] parent, int x)
    {
        if (parent[x] != x)
        {
            parent[x] = Find(parent, parent[x]);
        }

        return parent[x];
    }
}