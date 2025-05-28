// Last updated: 28/05/2025, 13:16:49
public class Solution {

    Random rand;
    int n;
    int[] _nums;
    int[] shuffled;

    public Solution(int[] nums) {
        _nums = nums;
        n = nums.Length;
        shuffled = new int[n];
        Array.Copy(_nums, shuffled, n);
        rand = new Random();
    }
    
    public int[] Reset() {
        Array.Copy(_nums, shuffled, n);
        return _nums;
    }
    
    public int[] Shuffle() {
        for(int i = 0; i < n; i++){
            int randIndex = rand.Next(0, shuffled.Length);
            int temp = shuffled[i];
            shuffled[i] = shuffled[randIndex];
            shuffled[randIndex] = temp;
        }
        return shuffled;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */