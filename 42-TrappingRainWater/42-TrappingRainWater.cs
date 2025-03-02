public class Solution {
    public int Trap(int[] height) {
        int totalAmount = 0;
        int L = 0;
        int R = height.Length - 1;
        int lMax = 0; // max height at L
        int rMax = height[R];// max height at R

        while (L < R)
        {
            if (height[L] <= height[R]) // Left height is less or equal to right height
            {
                if(height[L] < lMax)
                {
                    totalAmount += lMax - height[L]; // Water trapped on the left
                }
                else
                {
                    lMax = height[L];
                }
                L++;
            }
            else // Right height is less than left height
            {
                if(height[R] < rMax)
                {
                    totalAmount += rMax - height[R];
                }
                else
                {
                    rMax = height[R];
                }
                R--;
            }
        }

        return totalAmount;
    }
}