public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;

        for (int i = 0; i < n; i++) 
        {
            // Numbers within range [1, n]
            // While as if the value at nums[i] is swapped the new value will also need to be swapped to the correct place
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]) 
             {
                // Swap nums[i] with nums[nums[i] - 1]
                int temp = nums[i];
                nums[i] = nums[nums[i] - 1];
                nums[temp - 1] = temp;
            }
        }

        for (int i = 0; i < n; i++) // At each position find first time nums[i] is not i + 1
        {
            if (nums[i] != i + 1) 
            {
                return i + 1;
            }
        }

        return n + 1;
    }
}
