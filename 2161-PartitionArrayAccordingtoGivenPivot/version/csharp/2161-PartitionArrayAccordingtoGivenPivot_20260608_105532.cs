// Last updated: 08/06/2026, 10:55:32
1public class Solution {
2    public int[] PivotArray(int[] nums, int pivot) {
3        int n = nums.Length;
4        int[] result = new int[n];
5        int left = 0, right = n - 1;
6
7        for (int i = 0, j = nums.Length - 1; i < n; i++, j--){
8            if (nums[i] < pivot){
9                result[left] = nums[i];
10                left++;
11            }
12
13            if (nums[j] > pivot){
14                result[right] = nums[j];
15                right--;
16            }
17        }
18
19        while (left <= right){
20            result[left] = pivot;
21            left++;
22        }
23
24        return result;
25    }
26}