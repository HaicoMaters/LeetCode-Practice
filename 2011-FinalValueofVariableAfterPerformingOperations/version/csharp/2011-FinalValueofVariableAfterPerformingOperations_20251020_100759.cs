// Last updated: 20/10/2025, 10:07:59
public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x = 0;

        // will only be '++X', 'X++', 'X--' '--X' just check if 2nd index is + or - 

        foreach (string op in operations)
        {
            if (op[1] == '+')
            {
                x++;
            }
            else
            {
                x--;
            }
        }

        return x;
    }
}