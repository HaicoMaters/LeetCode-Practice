// Last updated: 28/05/2025, 13:14:41
public class Solution {
    public int SubsetXORSum(int[] nums) {
        return BackTrack(nums, 0, 0);
    }

    public int BackTrack(int[] nums, int start, int currentXOR){
        int sum = currentXOR; // Initialize the sum with the XOR of the current subset
        
        for (int i = start; i < nums.Length; i++) {
            // Include nums[i] in the current subset and compute the new XOR sum
            sum += BackTrack(nums, i + 1, currentXOR ^ nums[i]);
        }
        return sum;
    }
}
