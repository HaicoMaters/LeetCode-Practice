// Last updated: 06/04/2025, 14:37:38
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