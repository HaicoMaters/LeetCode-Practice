// Last updated: 18/08/2025, 12:33:05
public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] freq = new int[101]; // 0 <= nums[i] <= 100

        foreach (int num in nums)
        {
            freq[num]++;
        }

        // prefix sum
        for (int i = 1; i < 101; i++)
        {
            freq[i] += freq[i-1];
        }

        int[] smallerNums = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                smallerNums[i] = freq[nums[i] - 1];
            } 
        }

        return smallerNums;
    }
}