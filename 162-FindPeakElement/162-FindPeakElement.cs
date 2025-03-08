public class Solution {
    public int FindPeakElement(int[] nums) {
        int start = 0;
        int end = nums.Length - 1;

        while (start < end){
            int mid = start + (end - start) / 2;

            // Move according to slope if reaches 0 or n-1, -1 and n are considered -infinity so will work
            if (nums[mid] < nums[mid + 1]) {
                start = mid + 1;
            } 
            else {
                end = mid;
            }
        }

        return start;
    }
}