// Last updated: 28/05/2025, 13:16:19
using System.Text.RegularExpressions;

public class Solution {
    public string FractionAddition(string expression) {
        // Extract fractions using Regex
        MatchCollection matches = Regex.Matches(expression, @"[+-]?\d+\/\d+");
        
        int numerator = 0, denominator = 1;

        foreach (Match match in matches) {
            string[] fraction = match.Value.Split('/');
            int num = int.Parse(fraction[0]);
            int den = int.Parse(fraction[1]);

            // Add fractions: num1/den1 + num2/den2 = (num1 * den2 + num2 * den1) / (den1 * den2)
            numerator = numerator * den + num * denominator;
            denominator *= den;

            // Reduce fraction
            int gcd = GCD(Math.Abs(numerator), denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        return $"{numerator}/{denominator}";
    }

    private int GCD(int a, int b) {
        return b == 0 ? a : GCD(b, a % b);
    }
}
