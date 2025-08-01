// Last updated: 01/08/2025, 12:31:45
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> triangle = new List<IList<int>>();

        triangle.Add(new List<int>{1}); // First row;

        for (int i = 1; i < numRows; i++)
        {
            List<int> row = new List<int>{1}; // Each row starts with 1

            for (int j = 0; j < triangle[i-1].Count - 1; j++) // Combine all the ones in the middle using row above
            {
                row.Add(triangle[i-1][j] + triangle[i-1][j + 1]);
            }

            row.Add(1); // Ends with a 1
            triangle.Add(row);
        }

        return triangle;
    }
}