// Last updated: 22/04/2025, 12:28:58
public class Solution {
    public bool IsUgly(int n) {
        if (n < 1) return false;
        while (n % 2 == 0) n /= 2; // Take out all factors of 2
        while (n % 3 == 0) n /= 3; // Take out all factors of 3
        while (n % 5 == 0) n /= 5; // Take out all factors of 5
        return n == 1; // Should be one as should have only all of those factors
    }
}