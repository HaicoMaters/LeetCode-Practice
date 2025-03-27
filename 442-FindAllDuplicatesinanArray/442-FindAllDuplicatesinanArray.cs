// Last updated: 27/03/2025, 15:34:59
public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        List<int> dupes = new List<int>();

        // [1 - n] as values means that can be made into a hash where te index should be [i - 1] = i

        // Works by finding the index based on the val of nums[i] - 1, e.g. if 2 then index 1 should be referenced
        // Here we change the number nums[i] by making negative to show that it has been visited before
        // next we traverse the array and keep doing this
        // if for example the same number is nums[i] - 1 that has already occured e.g. index 1 for 2
        // then we visit index 1 and see that the value is negative
        // by this we know that it has already been visited i.e. the number at nums[i] exists twice so we can add
        // nums[i] the the list of dupes
        // here we also make sure to take the positive values for good indexing
        // O(N) Time, O(1) auxillary space
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;

            if (nums[index] < 0) // Already visited
            {
                dupes.Add(Math.Abs(nums[i]));
            }

            nums[index] = -nums[index];
        }

        return dupes;
    }
}