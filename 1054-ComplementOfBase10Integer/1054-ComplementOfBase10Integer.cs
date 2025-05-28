// Last updated: 28/05/2025, 13:15:46
public class Solution {
    public int BitwiseComplement(int n) {
        int bitLength = (int) Math.Log(n, 2)+1;
        int mask = (1 << bitLength) - 1;

        return n ^ mask;
    }
}