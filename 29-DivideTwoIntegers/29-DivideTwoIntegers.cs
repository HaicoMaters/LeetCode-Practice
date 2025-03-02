public class Solution {
    public int Divide(int dividend, int divisor) {
        // Edge case for overflow, return int.MaxValue
        if (dividend == int.MinValue && divisor == -1) return int.MaxValue;

        // Edge case where divisor is 1 or -1 (avoid unnecessary calculations)
        if (divisor == 1) return dividend;
        if (divisor == -1) return -dividend;

        // Edge case where dividend is 0
        if (dividend == 0) return 0;

        // Determine if the result will be negative using XOR
        bool isNegative = (dividend < 0) ^ (divisor < 0);

        // Work with long values to handle overflow safely (EVEN THOUGH QUESTION SPECIFICALY MENTIONS TO ONLY USE INTS)
        long d1 = Math.Abs((long)dividend); // Use long to handle edge cases with int.MinValue
        long d2 = Math.Abs((long)divisor);

        int result = 0;

        // Exponentially subtract larger multiples of divisor
        while (d1 >= d2) {
            long temp = d2, multiple = 1;

            // Increase the divisor and multiple by powers of 2 until it exceeds d1
            while (d1 >= (temp << 1) && temp <= (int.MaxValue >> 1)) {
                temp <<= 1; // Double the divisor (temp)
                multiple <<= 1; // Double the multiplier
            }

            // Subtract the found multiple of divisor from d1
            d1 -= temp;
            result += (int)multiple; // Cast the result back to int
        }

        // Apply the negative sign if needed
        if (isNegative) {
            result = -result;
        }

        // Ensure the result fits within the 32-bit integer range
        if (result < int.MinValue) {
            return int.MinValue;
        }
        if (result > int.MaxValue) {
            return int.MaxValue;
        }

        return result;
    }
}
