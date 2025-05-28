// Last updated: 28/05/2025, 13:14:02
public class Solution {
    public int MinimumOperations(int[] nums) {
        int operations = 0;
        for (int i = 0; i < nums.Length; i++){
            int remainder = nums[i] % 3;
            
            if (remainder == 0) continue;
            else operations++; // will either be 1 or 2 which would make - 1 or + 1 takes only one action (do not need to worry about 0 in testcases)
        }

        return operations;
    }
}