public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int rows = triangle.Count;
        List<List<int>> sum = new List<List<int>>();

        // First row of the triangle
        sum.Add(new List<int> { triangle[0][0] });

        for (int i = 1; i < rows; i++) {
            var row = triangle[i];
            sum.Add(new List<int>(new int[row.Count])); // Initialize list with correct size

            for (int j = 0; j < row.Count; j++) {
                int smallestAbove = int.MaxValue;

                if (j < sum[i - 1].Count){
                    smallestAbove = sum[i - 1][j]; // Would be the above right in the example
                }
                if (j > 0){
                    smallestAbove = Math.Min(smallestAbove, sum[i - 1][j - 1]); // The above left in the example
                }

                sum[i][j] = triangle[i][j] + smallestAbove;
            }
        }

        // Find the minimum in the last row
        int min = sum[rows - 1][0];
        for (int i = 1; i < sum[rows - 1].Count; i++) {
            min = Math.Min(min, sum[rows - 1][i]);
        }

        return min;
    }
}
