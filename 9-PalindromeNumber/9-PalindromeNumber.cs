public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false; // No negatives Or numbers Ending with 0 that are not 0
        }
        
        string s = x.ToString();
        int L = 0;
        int R = s.Length -1;
        while (L <= R)
        {
            if (s[L] != s[R])
            {
                return false;
            }
            L ++;
            R --;
        }

        return true;
    }
}