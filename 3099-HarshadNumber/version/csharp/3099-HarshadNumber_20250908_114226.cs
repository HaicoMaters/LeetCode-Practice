// Last updated: 08/09/2025, 11:42:26
public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        int digSum = 0;

        int a = x;
        while (a > 0)
        {
            digSum += a %10;
            a /= 10;
        }

        if (x % digSum == 0) return digSum;

        return -1;
    }
}