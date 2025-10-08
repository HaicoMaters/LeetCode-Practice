// Last updated: 08/10/2025, 11:09:09
public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);

        int n = spells.Length;
        int m = potions.Length;
        int[] pairs = new int[n];

        for (int i = 0; i < n; i++)
        {
            int spell = spells[i];
            int idx = BinSearch(spell, success, potions);
            pairs[i] = (idx == -1) ? 0 : m - idx;
        }

        return pairs;
    }

    int BinSearch(int spell, long success, int[] potions)
    {
        int l = 0;
        int r = potions.Length - 1;
        int idx = -1;

        while (l <= r)
        {
            int mid = l + (r-l)/2;

            if ((long)potions[mid] * (long)spell >= success)
            {
                idx = mid;
                r = mid-1;
            }
            else
            {
                l = mid+1;
            }
        }

        return idx;
    }
}