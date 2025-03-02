public class Solution {
    public int SingleNumber(int[] nums) {
        int number = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            number = number ^ nums[i];
        }
        return number;
    }
}