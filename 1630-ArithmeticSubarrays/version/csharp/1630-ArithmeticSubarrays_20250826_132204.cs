// Last updated: 26/08/2025, 13:22:04
public class Solution {
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) { // solution without sorting for n^2 instead of n^2logN
        List<bool> checks = new List<bool>();
        int queries = l.Length;

        for (int i = 0; i < queries; i++)
        {
            int L = l[i];
            int R = r[i];

            HashSet<int> vals = new HashSet<int>();
            int minVal = int.MaxValue;
            int maxVal = int.MinValue;

            for (int j = L; j < R + 1; j++)
            {
                vals.Add(nums[j]);
                minVal = Math.Min(minVal, nums[j]);
                maxVal = Math.Max(maxVal, nums[j]);
            }

            int len = R - L + 1;

            if (vals.Count == 1) // if all are the same num in the subsequence
            {
                checks.Add(true);
                continue;
            }

            if (vals.Count != len)
            {
                checks.Add(false);
                continue;
            }

            // Difference must divide evenly
            if ((maxVal - minVal) % (len - 1) != 0) 
            {
                checks.Add(false);
                continue;
            }

            int targetDiff = (maxVal - minVal) / (len - 1); // the difference that each member of a sequence should be appart

            bool ok = true;
            for (int k = 0; k < len; k++) {
                if (!vals.Contains(minVal + k * targetDiff)) {
                    ok = false;
                    break;
                }
            }

            checks.Add(ok);
        }

        return checks;
    } 
}