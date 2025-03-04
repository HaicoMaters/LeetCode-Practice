public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if (n == 0) return;
        int r = m + n - 1;
        n--;
        m--;
        while (m >= 0 && n >= 0)
        {
            if (nums1[m] > nums2[n])
            {
                nums1[r] = nums1[m];
                m--;
            }
            else
            {
                nums1[r] = nums2[n];
                n--;
            }
            r--;
        }

        // Copy remaining elements from nums2 (if any)
        while (n >= 0) 
        {
            nums1[r] = nums2[n];
            n--;
            r--;
        }
    }
}