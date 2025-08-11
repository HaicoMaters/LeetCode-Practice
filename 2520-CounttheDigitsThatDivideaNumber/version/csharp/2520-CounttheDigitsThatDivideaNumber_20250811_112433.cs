// Last updated: 11/08/2025, 11:24:33
public class Solution {
    public int CountDigits(int num) {
        int count = 0;
        int val = num;

        while (val > 0)
        {
            int digit = val % 10;
            val /= 10;

            if (num % digit == 0)
            {
                count++;
            }
        }

        return count;
    }
}