// Last updated: 23/10/2025, 12:08:20
public class Solution {
    public bool HasSameDigits(string s) {
        int operations = 0;
        char[] str = s.ToCharArray();
        int n  = s.Length;

        while (n - operations != 2)
        {
            for (int i = 0; i < n - 1 - operations; i++)
            {
                str[i] = (char)(((str[i] - '0') + (str[i+1] - '0')) % 10 + '0');
            }
            operations++;
        }

        return str[0] == str[1];
    }
}