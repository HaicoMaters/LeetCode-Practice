public class Solution {
    public bool IsHappy(int n) 
    {
        HashSet<int> seen = new HashSet<int>();
        while (!seen.Contains(n) && n != 1)
        {
            seen.Add(n);

            int total = 0;
            while (n > 0)
            {
                int digit = n % 10;
                total += digit * digit;
                n /= 10;
            }
            n = total;
        }
        return n == 1;
    }
}