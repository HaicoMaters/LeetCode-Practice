// Last updated: 15/05/2025, 13:09:04
public class Solution {
    public long MinSum(int[] nums1, int[] nums2) {
        
		long sum1 = 0;
		long sum2 = 0;
        long zeros1 = 0;
        long zeros2 = 0;

        // Get variables for nums1
        for(int i = 0; i < nums1.Length; i++)
        {
            sum1 += nums1[i];
            if (nums1[i] == 0) zeros1++;
        }

        // Get variables for nums2
        for(int i = 0; i < nums2.Length; i++)
        {
            sum2 += nums2[i];
            if (nums2[i] == 0) zeros2++;
        }

        // Solve the sum
        if (sum1 + zeros1 > sum2 + zeros2)
		{
			if (zeros2 == 0) return -1;

			return sum1 + zeros1;
		}
		else if (sum1 + zeros1 < sum2 + zeros2)
		{
			if (zeros1 == 0) return -1;

			return sum2 + zeros2;
		}
		
        return sum1 + zeros1;
    }
}