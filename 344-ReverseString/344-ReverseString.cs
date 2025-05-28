// Last updated: 28/05/2025, 13:17:28
public class Solution {
    public void ReverseString(char[] s) {
        int n = s.Length;

        for (int i = 0; i < n/2; i++)
        {
            char temp = s[i];
            s[i] = s[n - 1 - i];
            s[n - i - 1] = temp;
        }
    }
}