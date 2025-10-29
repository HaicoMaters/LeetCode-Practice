// Last updated: 29/10/2025, 10:39:15
public class Solution {
    public int SmallestNumber(int n) {
        // all powers of 2 - 1 (up to 1024 - 1, n <= 1000)
        int[] setBits = new int[]{1,3,7,15,31,63,127,255,511,1023};

        for (int i = 0; i < setBits.Length; i++)
        {
            if (n <= setBits[i]) return setBits[i];
        }

        return -1;
    }
}