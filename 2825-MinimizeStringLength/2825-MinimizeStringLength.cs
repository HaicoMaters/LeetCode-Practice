// Last updated: 28/05/2025, 13:14:16
public class Solution {
    public int MinimizedStringLength(string s) {
        return new HashSet<char>(s).Count;
    }
}