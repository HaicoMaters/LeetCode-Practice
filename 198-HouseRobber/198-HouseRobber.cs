public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        int[] total = new int[n];

        
        if (n == 0) return 0;
        if (n == 1) return nums[0];

        total[0] = nums[0];
        total[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < n; i++)
        {
            // Choose between skipping the current house or robbing it (which adds the profit from two houses ago)
            total[i] = Math.Max(total[i-1], total[i-2] + nums[i]);
        }   

        return total[n-1];
    }
}