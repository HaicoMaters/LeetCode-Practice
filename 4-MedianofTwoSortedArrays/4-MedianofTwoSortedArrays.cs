public class Solution
{
    // O(m+n) binary search solution
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int mergedArraySize = nums1.Length + nums2.Length;
        int nums1Index = 0;
        int nums2Index = 0;

        // Helper function to get the next smallest number and increment the appropriate index
        int GetNextNumber()
        {
            if (nums1Index < nums1.Length && (nums2Index >= nums2.Length || nums1[nums1Index] <= nums2[nums2Index]))
            {
                return nums1[nums1Index++];
            }
            else
            {
                return nums2[nums2Index++];
            }
        }

        if (mergedArraySize % 2 == 0) // Even case
        {
            int targetIndex1 = mergedArraySize / 2 - 1;
            int targetIndex2 = mergedArraySize / 2;
            int median1 = 0, median2 = 0;

            for (int i = 0; i <= targetIndex2; i++)
            {
                int nextNumber = GetNextNumber();
                if (i == targetIndex1) median1 = nextNumber;
                if (i == targetIndex2) median2 = nextNumber;
            }

            return (median1 + median2) / 2.0;
        }
        else // Odd case
        {
            int targetIndex = mergedArraySize / 2;
            int median = 0;

            for (int i = 0; i <= targetIndex; i++)
            {
                median = GetNextNumber();
            }

            return median;
        }
    }
}
