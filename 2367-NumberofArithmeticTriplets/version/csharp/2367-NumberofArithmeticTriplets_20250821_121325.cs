// Last updated: 21/08/2025, 12:13:25
public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        HashSet<int> set = new HashSet<int>(nums);
        int triplets = 0;

        for (int i = 1; i < nums.Length -1; i++)
        {
            if (set.Contains(nums[i] - diff) && set.Contains(nums[i] + diff))
            {
                triplets++;
            }
        }

        return triplets;
    }
}