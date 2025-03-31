// Last updated: 31/03/2025, 18:24:52
public class NumArray {

    private int[] sums;

    public NumArray(int[] nums) {

        sums = new int[nums.Length];
        sums[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            sums[i] = sums[i - 1] + nums[i];
        }
    }
    
    public int SumRange(int left, int right) {

        if (left == 0) return sums[right];
        
        return sums[right] - sums[left - 1]; 
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */