public class Solution {
    public int HammingWeight(int n) {
        int count = 0;
        while (n != 0) {
            count += (n & 1); // Check if the last bit is 1
            n = n >> 1;      // Shift right
        }
        return count;
    }
}