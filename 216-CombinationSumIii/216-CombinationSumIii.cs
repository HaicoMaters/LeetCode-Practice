// Last updated: 28/05/2025, 13:17:49
public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        List<IList<int>> combinations = new List<IList<int>>();

        if (k == 0 || n < 1) return combinations;

        CombinationSum3(k, n, 0, 1, combinations, new List<int>());   
        return combinations;
    } 

    public void CombinationSum3(int k, int n, int sum, int start, List<IList<int>> combinations, List<int> Used)
    {
        if (Used.Count == k)
        {
            if (sum == n) combinations.Add(Used);
            return;
        }

        for (int i = start; i <= 9; i++)
        {
            if (sum + i > n) break;

            Used.Add(i);
            CombinationSum3(k, n, sum + i, i + 1, combinations, new List<int>(Used));

            // Remove For Backtracking
            Used.RemoveAt(Used.Count - 1);
        }
    }
}