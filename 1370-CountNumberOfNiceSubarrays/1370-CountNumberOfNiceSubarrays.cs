// Last updated: 28/05/2025, 13:15:30
public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {

        int subarrayCount = 0;
        int oddCount = 0;
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if(nums[right] % 2 != 0)
            {
                oddCount++;
            }

            if(oddCount == k) // New Subbarray found
            {
                subarrayCount++;

                int innerCount = left;

                while(nums[innerCount] % 2 == 0) // Extend rightwards until find the next odd occurance
                {
                    innerCount++;
                    subarrayCount++;
                }
            }

            if(right + 1 < nums.Length && nums[right + 1] % 2 != 0 && oddCount == k) 
            {
                // shrink window moving left to right until odd count is equal to k after next odd
                while(nums[left] % 2 == 0)
                {
                    left++;
                }

                left++;
                oddCount--;
            }
        }

        return subarrayCount;
    }
}