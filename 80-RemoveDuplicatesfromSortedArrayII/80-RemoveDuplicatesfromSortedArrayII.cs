public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        if (nums.Length <= 2) return nums.Length; // If size is 2 or less, return as is

        int size = 2; // Allow first two occurrences
        for (int i = 2; i < nums.Length; i++) 
        {
            if (nums[i] != nums[size - 2]) 
            { 
                nums[size] = nums[i]; // Place valid element
                size++; 
            }
        }

        return size;
    }
}
