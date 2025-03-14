public class Solution {
    public int FindMaxK(int[] nums) {
        HashSet<int> numbers = new HashSet<int>();

        foreach (int num in nums) {
            numbers.Add(num);
        }

        int maxK = -1;
        
        foreach (int num in nums) {
            if (num > 0 && numbers.Contains(-num)) {
                maxK = Math.Max(maxK, num);
            }
        }

        return maxK;
    }
}
