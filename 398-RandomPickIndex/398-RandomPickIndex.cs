public class Solution {

    Random rand;
    Dictionary<int, List<int>> indices; // Number and list of indicies

    public Solution(int[] nums) {
        indices = new Dictionary<int, List<int>>();
        rand = new Random();  
        for (int i = 0; i < nums.Length; i++){
            if (!indices.ContainsKey(nums[i])){
                indices[nums[i]] = new List<int>();
            }
            indices[nums[i]].Add(i);
        }
    }
    
    public int Pick(int target) {
        List<int> targetIndices = indices[target];
        int randIndex = rand.Next(0, targetIndices.Count);

        return targetIndices[randIndex];
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */