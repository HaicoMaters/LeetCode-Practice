// Last updated: 16/09/2025, 11:53:45
public class Solution {
    public IList<int> ReplaceNonCoprimes(int[] nums) {
        List<int> stack = new List<int>(); // just using a list in a similar way to a stack

        foreach (int num in nums)
        {
            int y = num;
            while (stack.Count > 0)
            {
                int x = stack[stack.Count - 1];
                int gcd = GCD(x,y);
                if (gcd == 1)
                {
                    break;
                }
                stack.RemoveAt(stack.Count - 1);

                y = (x / gcd) * y; // merge 
            }
            stack.Add(y);
        }

        return stack;
    }

    public int GCD(int x, int y)
    {
        if (y == 0) return x;

        return GCD(y, x % y);
    }
}