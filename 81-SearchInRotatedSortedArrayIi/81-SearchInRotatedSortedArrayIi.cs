// Last updated: 28/05/2025, 13:18:27
public class Solution {
    public bool Search(int[] nums, int target) {
        // Binary Search two times if i + 1 < i that means k is at i + 1
        // Check if target between max and min of left, or right and adjust start and end apropriately
        int start = 0;
        int end = nums.Length - 1;
        while (start <= end){

            int mid = (start + end)/2;
            if (nums[mid] == target) return true;

            if (nums[start] == nums[mid]){
                start++;
                continue;
            }

            // Search left
            if (nums[start] <= nums[mid]){
                // Target would be within the range due to how array is sorted
                if (nums[start] <= target && target <= nums[mid]){
                    end = mid - 1;
                }
                else{
                    start = mid + 1; // Not within left
                }
            }
            // Search right
            else{
                // Target would be within the range due to how array is sorted
                if (nums[end] >= target && nums[mid] <= target){
                    start = mid + 1;
                }
                else{
                    end = mid - 1; // Not within right
                }
            }
        }
        return false;
    }
}