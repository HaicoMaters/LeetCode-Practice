public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary <int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int reqiredNum = target - nums[i];
        
            if (map.ContainsKey(reqiredNum)) 
            {
              return new int[] { map[reqiredNum], i };
            }
            map[nums[i]] = i;
        }

        throw new Exception("No two sum solution found");
    }
}