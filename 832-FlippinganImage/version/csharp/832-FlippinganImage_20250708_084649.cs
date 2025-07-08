// Last updated: 08/07/2025, 08:46:49
public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        
        int n = image.Length;

        for (int i = 0; i < n; i++)
        {
            Array.Reverse(image[i]); // Flip
            
            for (int j = 0; j < n; j++)
            {
                image[i][j] = (image[i][j] == 1) ? 0 : 1;   // Invert

            }
        }

        return image;
    }
}