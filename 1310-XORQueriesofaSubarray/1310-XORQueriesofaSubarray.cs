// Last updated: 28/03/2025, 14:51:55
public class Solution {
    public int[] XorQueries(int[] arr, int[][] queries) {
        int n = queries.Length;

        int[] xors = new int[n];

        for (int i = 0; i < n; i++)
        {
            int xor = 0;

            for (int j = queries[i][0]; j <= queries[i][1]; j++)
            {
                xor ^= arr[j]; 
            }

            xors[i] = xor;
        }

        return xors;
    }
}