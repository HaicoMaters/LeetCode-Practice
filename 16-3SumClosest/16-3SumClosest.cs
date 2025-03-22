// Last updated: 22/03/2025, 12:39:18
public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);  // Sort the array for two-pointer traversal

        int closest = int.MaxValue;  
        int result = 0;  

        for (int i = 0; i < nums.Length - 2; i++) {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                if (Math.Abs(target - sum) < closest) {
                    closest = Math.Abs(target - sum);
                    result = sum;
                }

                if (sum < target) {
                    left++;
                } 
                else if (sum > target) {
                    right--;
                }
                else{
                    return target; // Sum is target
                }
            }
        }

        return result;
    }
}
