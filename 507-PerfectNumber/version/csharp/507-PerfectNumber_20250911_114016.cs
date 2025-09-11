// Last updated: 11/09/2025, 11:40:16
public class Solution {
    public bool CheckPerfectNumber(int num) {

        int sum = 0;
        for (int i = 1; i <= Math.Sqrt(num); i++) // sqrt is largest possble divisor (not counting itself)
        {
            if (num % i == 0)
            {
                sum += i;

                if (i != num / i) // add the other divisor (except sqrt twice)
                {
                    sum += num / i;
                }
            }
        }

        return sum - num == num;
    }
}