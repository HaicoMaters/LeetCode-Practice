public class Solution {
    public IList<int> LuckyNumbers(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;

        List<int> minRow = new List<int>();
        for (int i = 0; i < m; i++)
        {
            int min = int.MaxValue;
            for (int j = 0; j < n; j++)
            {
                min = Math.Min(min, matrix[i][j]);
            }
            minRow.Add(min);
        }

        List<int> maxCol = new List<int>();
        for (int j = 0; j < n; j++)
        {
            int max = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                max = Math.Max(max, matrix[i][j]);
            }
            maxCol.Add(max);
        }

        List<int> result = new List<int>();
        foreach (int val in minRow){
            if (maxCol.Contains(val)){
                result.Add(val);
            }
        }
        return result;
    }
}