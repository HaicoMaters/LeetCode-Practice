// Last updated: 28/05/2025, 13:15:32
public class Solution {
    public int FindNumbers(int[] nums) {
        int count = 0;

        foreach (int num in nums)
        {
            int digits = 0;
            int n = num;

            while (n > 0)
            {
                n /= 10;
                digits++;
            }

            if (digits % 2 == 0)
            {
                count++;
            }
        }
        
        return count;
    }
}