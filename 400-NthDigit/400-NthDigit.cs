public class Solution {
    public int FindNthDigit(int n) {
        if (n < 10) return n;

        // number 1-9 = 9
        // numbers 10-99 = 90 * 2(digits) = 180
        // numbers 100-999 = 900 * 3(digits) = 2700
        
        // For example n = 29 corresponds to the digit 9 in the number 19
        // subtract the digits from the 1-digit range: n = 29 - 9 = 20 as it is within the range of two digits (between 10 - 189)
        // 2 digits in this case so (n - 1) / 2 gives us the index of the number.
        // (20 - 1) / 2 = 9, which means the index is 9
        // the first number in this range is 10, so 10 + 9 = 19
        // (n - 1) % 2 = 1, so the second digit of 19 is '9', which is 29th digit

        long mult = 90; // 9 for 1-9, 90 for 10-99 etc.
        int digits = 2; // number of digits per number
        int start = 10; // first digit within range
        n -= 9;
        // Get the Range of n
        while(n > mult * digits){
                n -= (int)(digits * mult);
                digits++;
                start *= 10;
                mult *= 10;
        }

        int num = start + (n-1) / digits; // tje full number containing the digit e.g. 152 
        string numStr = num.ToString();
        return numStr[(n - 1) % digits] - '0'; // Extract the correct digit
    }
}