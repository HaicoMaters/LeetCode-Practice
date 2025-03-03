public class Solution {
    public int FindJudge(int n, int[][] trust) {
        int[] trustedBy = new int[n];
        int[] trusts = new int[n];
        for(int i = 0; i < trust.Length; i++)
        {
            trusts[trust[i][0] - 1]++;
            trustedBy[trust[i][1] - 1]++;
        }

        for (int i = 0; i < n; i++)
        {
            if (trustedBy[i] == n - 1 && trusts[i] == 0)
            {
                return i + 1;
            }
        }

        return -1;
    }
}