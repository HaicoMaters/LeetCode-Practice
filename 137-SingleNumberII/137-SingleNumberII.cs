public class Solution {
    public int SingleNumber(int[] nums) {

        int ones = 0; // Tracks the bits that have appeared once
        int twos = 0; // Tracks the bits that have appeared twice
    
        for (int i = 0; i < nums.Length; i++) 
        {
            int num = nums[i];
        // & ~twos means not in twos so the if the bit exists in twos it is not updated when the third of the same appears
            ones = (ones ^ num) & ~twos;
            twos = (twos ^ num) & ~ones;
        }
        
        return ones;
    }
}