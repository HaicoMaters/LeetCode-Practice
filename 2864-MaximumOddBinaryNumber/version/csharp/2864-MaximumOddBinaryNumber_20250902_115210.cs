// Last updated: 02/09/2025, 11:52:10
public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int countOf1s = 0;

        foreach (char c in s)
        {
            if (c == '1') countOf1s++;
        }

        int n = s.Length;

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n -1; i++)
        {
            if (countOf1s > 1)
            {
                sb.Append('1');
                countOf1s--;
            }
            else
            {  
                sb.Append('0');
            }
        }

        sb.Append('1');
        return sb.ToString();
    }
}