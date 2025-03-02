public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int start = 0; 
        int end = nums.Length - 1;

        while (start <= end) 
        {
            int midPoint = start + (end - start) / 2;

            if (nums[midPoint] == target) 
            {
                return midPoint;
            } 
            // Search above midpoint
            else if (nums[midPoint] < target) 
            {
                start = midPoint + 1;
            } 
            // Search below midpoint
            else 
            {
                end = midPoint - 1;
            }
        }
        return start;
    }
}