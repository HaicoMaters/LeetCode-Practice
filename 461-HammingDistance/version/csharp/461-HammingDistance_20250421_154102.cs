// Last updated: 21/04/2025, 15:41:02
public class Solution {
    public int HammingDistance(int x, int y) {
        int num = x ^ y;
        int count = 0;
        while (num > 0)
        {
            count += num & 1;
            num >>=1;
        }
        return count;
    }
}