// Last updated: 08/07/2025, 08:34:24
public class Solution {
    public int MissingNumber(int[] nums) {
        int xor = 0;
        
        for (int i = 0; i <= nums.Length; i++)
        {
            xor = xor ^ i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            xor = xor ^ nums[i];
        }

        return xor;
    }
}