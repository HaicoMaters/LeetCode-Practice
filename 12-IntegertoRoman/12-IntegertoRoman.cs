public class Solution {
    public string IntToRoman(int num) 
    {
        StringBuilder roman = new StringBuilder();
        int[] values = new int[] {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        string[] symbols = new string[] {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

        for (int i = 0; i < values.Length; i++) {
            while (num >= values[i]) {
                roman.Append(symbols[i]);
                num -= values[i];
            }
        }

        return roman.ToString();
    }
}