public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }

        int k = 1;
        int lastUnique = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != lastUnique) {
                nums[k] = nums[i]; 
                lastUnique = nums[i];
                k++; 
            }
        }

        return k;
    }
}
