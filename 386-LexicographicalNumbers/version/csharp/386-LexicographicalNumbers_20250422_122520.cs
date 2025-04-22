// Last updated: 22/04/2025, 12:25:20
public class Solution {
    public IList<int> LexicalOrder(int n) {
        List<int> order = new List<int>();
        int current = 1;

        for (int i = 0; i < n; i++)
        {
            order.Add(current);

            // Mult by 10, i.e. so in order 1 -> 10 -> 100 -> 11 (if n was 100)
            if (current * 10 <= n)
            {
                current *= 10;
            }
            else if (current % 10 != 9 && current + 1 <= n) // Increment, if last digit is not 9, and within range (i.e. so it wont go 9 -> 10, after the 10 has already been used due to lexical ordering)
            {
                current++;
            }
            else // Backtrack, until can increment to next valid number (ensure that the last digit is not 9, i.e. goes 128 -> 129 -> 13)
            {
                while ((current / 10) % 10 == 9)
                {
                    current/=10;
                }
                current = current / 10 + 1;
            }
        }
    
        return order;
    }
}