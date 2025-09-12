// Last updated: 12/09/2025, 11:36:20
public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);

        int count = 0;
        int i = 0;

        for (int j = 0; j < s.Length; j++)
        {
            if (i < g.Length && s[j] >= g[i])
            {
                count++;
                i++;
            }
        }

        return count;
    }
}