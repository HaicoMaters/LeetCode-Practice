// Last updated: 28/05/2025, 13:16:28
public class Solution {
    public int[] ConstructRectangle(int area) {
        int width = (int)Math.Sqrt(area);
        
        while (area % width != 0) // Find the highest possible factor that is not the area itself (unless it is only factor)
        {
            width--;
        }

        int length = area / width;

        int[] rectangle = new int[2]{length, width};
        return rectangle;
    }
}