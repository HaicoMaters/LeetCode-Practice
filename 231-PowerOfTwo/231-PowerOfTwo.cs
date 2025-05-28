// Last updated: 28/05/2025, 13:17:43
public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n < 1) return false;

        // Bitwise solution for powers of two e.g. 1000 that - 1 is 0111 so the & will give 0000 and for non powers of two e.g. 1100 (12) 
        // -1 gives 1011 and doing an & you get 1000 which is not 0 so not a power of two
        return (n & (n-1)) == 0;
    }
}