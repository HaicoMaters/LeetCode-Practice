// Last updated: 30/04/2025, 11:36:52
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