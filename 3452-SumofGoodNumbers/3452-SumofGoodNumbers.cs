public class Solution {
    public int SumOfGoodNumbers(int[] nums, int k) {
        int sum = 0;
        int n = nums.Length;

        for (int i = 0; i < n; i++) 
        {
            int val = nums[i];
            bool firstCheck = true;
            bool secondCheck = true;

            if (i >= k) firstCheck = val > nums[i - k];
            if (i + k < n) secondCheck = val > nums[i + k]; 

            if (firstCheck && secondCheck) 
            {
                sum += val;
            }
        }

        return sum;
    }
}
