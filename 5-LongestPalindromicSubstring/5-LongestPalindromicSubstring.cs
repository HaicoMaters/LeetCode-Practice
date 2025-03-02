public class Solution {
    public string LongestPalindrome(string s) {
        // Pointer At Front Of Substring And Pointer At Back
        // Char At Front Always Equal to Char At Back
        int L;
        int R;
        string subString = "";
        string longestPalindrome = "";

        for (int i = 0; i < s.Length; i++) {
            
            // Check for odd-length palindromes (centered at i)
            L = i;
            R = i;
            while (L >= 0 && R < s.Length && s[L] == s[R]) {
                subString = s.Substring(L, R - L + 1);  // Substring from L to R (inclusive)
                if (subString.Length > longestPalindrome.Length) {
                    longestPalindrome = subString;
                }
                L--;
                R++;
            }

            // Check for even-length palindromes (centered between i and i + 1)
            L = i;
            R = i + 1;
            if (R < s.Length && s[L] == s[R]) {
                while (L >= 0 && R < s.Length && s[L] == s[R]) {
                    subString = s.Substring(L, R - L + 1);  // Substring from L to R (inclusive)
                    if (subString.Length > longestPalindrome.Length) {
                        longestPalindrome = subString;
                    }
                    L--;
                    R++;
                }
            }
        }
        return longestPalindrome;
    }
}