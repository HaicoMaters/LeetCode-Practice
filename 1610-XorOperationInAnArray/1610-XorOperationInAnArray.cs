// Last updated: 28/05/2025, 13:14:51
public class Solution {
    public int XorOperation(int n, int start) {
        int ans = start + 2 * 0;
        
        for (int i = 1; i < n; i++){
            ans ^= start + 2 * i;
        }

        return ans;
    }
}