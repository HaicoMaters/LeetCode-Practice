public class Solution {
    public double MyPow(double x, int n) {
        if (x == 0) return 0;
        if (n == 0) return 1;

        long exp = n; // long to prevent overflow in case where n = int.MinValue
        if (exp < 0)
        {
            x = 1.0 / x;
            exp = -exp;
        }

        double ans = 1;
        while (exp > 0)
        {
            // Split into less calcs e.g. x^4 = (x^2)^2. n^6 = (x^3)^2
            if (exp %2 == 1)
            {
                ans *= x;   // in odd cases e.g. (x^3)^2 multiply and extra time by x
            }
            x *= x;
            exp /= 2;
        }

        return ans;
    }
}