// Last updated: 16/07/2025, 11:48:50
public class Solution {
    public int MaximumLength(int[] nums) {
        // cases where valid => all odd in subarray, all even in subarray, odd -> even -> odd -> even (and start with even -> odd)
        int oddEvenLength = 0; // sequence odd -> even
        int evenOddLength = 0; // sequence even -> odd
        int oddCount = 0; // sequence odd -> odd
        int evenCount = 0; // sequence even -> even

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 1)
            {
                if(oddEvenLength % 2 == 0) oddEvenLength++; // last was even
                if(evenOddLength % 2 == 1) evenOddLength++; 

                oddCount++;
            }
            else
            {
                if(oddEvenLength % 2 == 1) oddEvenLength++; // last was odd
                if(evenOddLength % 2 == 0) evenOddLength++;
                evenCount++;
            }
        }

        return Math.Max(Math.Max(evenOddLength, oddEvenLength), Math.Max(evenCount, oddCount));
    }
}