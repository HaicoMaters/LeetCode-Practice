// Last updated: 24/09/2025, 12:55:20
public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        if (numerator == 0) return "0";

        Dictionary<long, int> seen = new Dictionary<long,int>();
        StringBuilder sb = new StringBuilder();

        if ((numerator < 0) ^ (denominator < 0)) sb.Append("-");

        long num = Math.Abs((long) numerator);
        long den = Math.Abs((long) denominator);

        sb.Append(num / den);
        long rem = num % den;
        if (rem != 0) sb.Append(".");
        while (rem != 0)
        {
            if (seen.ContainsKey(rem))
            {
                int idx = seen[rem];
                sb.Insert(idx, "(");
                sb.Append(")");
                break;
            }

            seen[rem] = sb.Length;
            rem *= 10;
            sb.Append(rem / den);
            rem %= den;
        }

        return sb.ToString();
    }
}