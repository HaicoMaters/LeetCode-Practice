// Last updated: 21/03/2025, 13:52:46
public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int n = nums.Length;
        int[] result = new int[n];
        int left = 0, right = n - 1;

        for (int i = 0, j = nums.Length - 1; i < n; i++, j--){
            if (nums[i] < pivot){
                result[left] = nums[i];
                left++;
            }

            if (nums[j] > pivot){
                result[right] = nums[j];
                right--;
            }
        }

        while (left <= right){
            result[left] = pivot;
            left++;
        }

        return result;
    }
}