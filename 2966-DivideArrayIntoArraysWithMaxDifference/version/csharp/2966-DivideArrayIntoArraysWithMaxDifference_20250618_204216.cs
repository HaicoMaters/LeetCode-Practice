// Last updated: 18/06/2025, 20:42:16
public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        Array.Sort(nums);

        List<int[]> arrays = new List<int[]>();

        for (int i = 1; i < nums.Length; i += 3) // 3 nums per subarray
        {
            if(nums[i+1] - nums[i-1] > k && i + 1 < nums.Length) // cannot make arrays where difference between two elements is <= k
            {
                return [];
            }

            arrays.Add([nums[i - 1], nums[i], nums[i+1]]); // add new array
        }

        return arrays.ToArray();
    }
}