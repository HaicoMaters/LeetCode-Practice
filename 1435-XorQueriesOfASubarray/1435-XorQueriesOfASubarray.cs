// Last updated: 28/05/2025, 13:15:29
public class Solution {
    public int[] XorQueries(int[] arr, int[][] queries) { // Better O(n) solution
    int n = arr.Length;
        int[] prefixXor = new int[n + 1];
        int[] result = new int[queries.Length];

        for (int i = 0; i < n; i++) {
            prefixXor[i + 1] = prefixXor[i] ^ arr[i];
        }

        for (int i = 0; i < queries.Length; i++) {
            int left = queries[i][0];
            int right = queries[i][1];

            result[i] = prefixXor[right + 1] ^ prefixXor[left];
        }

        return result;
    }
}