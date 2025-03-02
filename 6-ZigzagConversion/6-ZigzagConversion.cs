public class Solution {
    public int Reverse(int x) {
        long result = 0; // Long to help against overflow
        while (x != 0)
        {
            int remainder = x % 10; // Get digit at the end of the number
            result = result * 10 + remainder; // Move the digits one space to the left and add the next digit to the end

            if (result > Int32.MaxValue || result < Int32.MinValue) // stop overflow
            {
                return 0;
            }
            x /= 10; // get rid of the final digit of x
        }

        return (int)result;
    }
}