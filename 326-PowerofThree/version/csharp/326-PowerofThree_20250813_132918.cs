// Last updated: 13/08/2025, 13:29:18
public class Solution {
    public bool IsPowerOfThree(int n) {
        int maxPowerOfThree = 1162261467; // 3^19 is the max in the integer limit (3^20 is 3,486,784,401 > 2^32-1)
        return n > 0 && (maxPowerOfThree % n == 0);
    }
}