public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;
        
        int currentIndex = n-1;

        digits[currentIndex]++;
        while (digits[currentIndex] == 10)
        {
            // Carry on the value
            digits[currentIndex] = 0;
            currentIndex--;

            // Case where array needs to be extended
            if (currentIndex != -1) digits[currentIndex]++;
            if (currentIndex == -1)
            {
                int[] newDigits = new int[n + 1];
                newDigits[0] = 1;
                Array.Copy(digits, 0, newDigits, 1, n);
                return newDigits;
            }
        }

        return digits;
    }
}