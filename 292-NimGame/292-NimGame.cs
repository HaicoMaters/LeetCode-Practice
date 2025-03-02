public class Solution {
    public bool CanWinNim(int n) {
        // In case where n is a multiple of 4 it is never possible to win if optimally played
        return n % 4 != 0;
    }
}