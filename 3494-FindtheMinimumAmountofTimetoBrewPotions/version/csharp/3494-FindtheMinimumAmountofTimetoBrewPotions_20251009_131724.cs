// Last updated: 09/10/2025, 13:17:24
public class Solution {
    public long MinTime(int[] skill, int[] mana) {
        int n = skill.Length;
        int m = mana.Length;

        long[] finished = new long[n+1];

        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                finished[i + 1] = Math.Max(finished[i+1], finished[i]) + (long)mana[j] * skill[i];
            }

            for (int i = n-1; i > 0; i--)
            {
                finished[i] = finished[i+1] - (long)mana[j] * skill[i];
            }
        }

        return finished[n];
    }
}