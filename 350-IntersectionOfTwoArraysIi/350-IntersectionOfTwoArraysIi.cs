// Last updated: 28/05/2025, 13:17:25
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);

        int n = nums1.Length;
        int m = nums2.Length;

        int num1 = 0; // pointer for nums1
        int num2 = 0; // poiter for nums2

        List<int> intercetions = new List<int>();

        while (num1 < n && num2 < m)
        {
            if (nums1[num1] == nums2[num2])
            {
                intercetions.Add(nums1[num1]);
                num1++;
                num2++;
            }
            else if (nums1[num1] < nums2[num2])
            {
                num1++;
            }
            else
            {
                num2++;
            }
        }

        return intercetions.ToArray();
    }
}