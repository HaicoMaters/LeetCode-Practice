public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int L = 0;
        int R = height.Length - 1;

        while (L < R)
        {
            int area = (R - L) * ((height[R] > height[L]) ? height[L] : height[R]);
            if (area > maxArea)
            {
                maxArea = area;
            }
            if (height[R] > height[L])
            {
                L++; 
            }
            else
            {
                R--;
            }
        }
        return maxArea;
    }
}