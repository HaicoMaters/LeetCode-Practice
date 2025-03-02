public class Solution {
    public int Jump(int[] nums) {
        int n = nums.Length;
        int jumps = 0;
        int farthest = 0;
        int end = 0;

        for(int i = 0; i < n - 1; i++)
        {
            farthest = Math.Max(farthest, i + nums[i]); // update Farthest possible reachable index per jump

            if (i == end) // found the current end so jump to the farthest position
            {
                jumps++;
                end = farthest; // create new range for next jump
            }
        }

        return jumps;
    }
}