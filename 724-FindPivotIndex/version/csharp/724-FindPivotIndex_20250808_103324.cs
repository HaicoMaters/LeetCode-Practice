// Last updated: 08/08/2025, 10:33:24
public class Solution {
    public int PivotIndex(int[] nums) {
        int sumRight = 0;
        int sumLeft = 0;

        foreach (int num in nums) sumRight += num;

        for (int i = 0; i < nums.Length; i++)
        {
            sumRight -= nums[i];

            if (sumLeft == sumRight) return i;

            sumLeft += nums[i];
        }

        return -1;
    }
}