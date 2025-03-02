public class Solution {
    public int ClimbStairs(int n) {
        // ways to reach step 1: 1, ways to reach step 2: 2 ways to reach step 3: 3 ways to reach step 4 : 5 ways to reach step 5: 8
        // After observing other values appears to be fibonacci sequence starting from steps 1 and
        if (n <= 3) return n; // Always is this for these values
        
        // Fill in to start the sequence // More memory efficent jyst use two ints instead of the array
        int ways = 3;
        int last = 2;

        for (int i = 3; i < n; i++)
        {
            int temp = ways + last;
            last = ways;
            ways = temp; // Add the previous two numbers
        }

        return ways;
    }
}