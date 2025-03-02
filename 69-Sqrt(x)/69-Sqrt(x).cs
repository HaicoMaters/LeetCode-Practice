public class Solution {
    public int MySqrt(int x) {
        if (x == 0 || x == 1) return x;

        int start = 1; // Start of search area
        int end = x; // Largest possible square

        while (start <= end)
        {
            int midpoint = start + (end - start) / 2;
            long midSquared = (long)midpoint * midpoint; // Long to avoid overflow

            if (midSquared > x)
            {
                end = midpoint - 1;
            }
            else if (midSquared == x)
            {
                return midpoint;
            }
            else {
                start = midpoint + 1;
            }
        }
        return end;
    }
}
