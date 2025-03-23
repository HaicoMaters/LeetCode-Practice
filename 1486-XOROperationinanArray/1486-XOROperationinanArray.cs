// Last updated: 23/03/2025, 17:23:59
public class Solution {
    public int XorOperation(int n, int start) {
        int ans = start + 2 * 0;
        
        for (int i = 1; i < n; i++){
            ans ^= start + 2 * i;
        }

        return ans;
    }
}