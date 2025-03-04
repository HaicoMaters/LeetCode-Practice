public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> ranges = new List<string>();

        if (nums == null || nums.Length == 0) return ranges;
        int start = nums[0];
        int range = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == (start + range + 1))
            {
                range++;
            }
            else
            {
                if (range == 0) ranges.Add(start.ToString());
                else ranges.Add($"{start}->{start+range}");
                start = nums[i];
                range = 0;
            }
        }

        // Add a last string object
        if (range == 0) ranges.Add(start.ToString());
        else ranges.Add($"{start}->{start+range}");

        return ranges;
    }
}