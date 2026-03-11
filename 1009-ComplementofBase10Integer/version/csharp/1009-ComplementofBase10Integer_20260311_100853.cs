// Last updated: 11/03/2026, 10:08:53
1public class Solution {
2    public int BitwiseComplement(int n) {
3        int bitLength = (int) Math.Log(n, 2)+1;
4        int mask = (1 << bitLength) - 1;
5
6        return n ^ mask;
7    }
8}