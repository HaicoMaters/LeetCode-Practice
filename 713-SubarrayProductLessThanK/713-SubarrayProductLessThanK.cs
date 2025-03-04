public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {

        if (k == 0) return 0;

        int subarrays = 0;
        int currentVal = 1;
        int currentLength = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            currentVal *= nums[i];
            currentLength++;

            while (currentVal >= k && currentLength > 0)
            {
                currentVal /= nums[i - currentLength + 1];
                currentLength--;
            }

            if (currentLength > 0)
            {
                // new subarrays are equal to length e.g. case 123 new ones are 123, 23, 3 (3) and for 1234 is 1234, 234, 34, 4
                subarrays += currentLength;
            }
        }

        return subarrays;
    }
}