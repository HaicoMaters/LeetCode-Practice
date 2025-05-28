// Last updated: 28/05/2025, 13:15:43
public class Solution {
    public int HeightChecker(int[] heights) {
        int[] expected = new int[heights.Length];
        heights.CopyTo(expected, 0);
        Array.Sort(expected);
        int count = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != expected[i])
            {
                count++;
            }
        }

        return count;
    }
}