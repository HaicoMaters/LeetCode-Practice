// Last updated: 28/07/2025, 13:01:18
public class Solution {
    int maxOr = 0;
    int count = 0;

    public int CountMaxOrSubsets(int[] nums) {
        foreach (int num in nums) // max bitwise-OR is bitwise-OR of whole array
        {
            maxOr |= num;
        }

        DFS(nums, 0, 0);
        return count;
    }

    public void DFS(int[] nums, int index, int currentOr)
    {
        if (index == nums.Length)
        {
            if (currentOr == maxOr)
            {
                count++;
            }
            return;
        }

        DFS(nums, index + 1, currentOr | nums[index]); // counts sets including nums[index]
        DFS(nums, index + 1, currentOr); // counts sets not including nums[index]
    }
}