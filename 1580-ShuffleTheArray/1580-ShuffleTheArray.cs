// Last updated: 28/05/2025, 13:14:54
public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] arr = new int[2 * n];
        
        for (int i = 0; i < n; i++) {
            arr[2 * i] = nums[i];
            arr[2 * i + 1] = nums[n + i];
        }
        
        return arr;
    }
}
