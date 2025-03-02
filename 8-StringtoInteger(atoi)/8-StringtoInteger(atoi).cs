public class Solution {
    public int MyAtoi(string s) {

        int INT_MAX = int.MaxValue;
        int INT_MIN = int.MinValue;

        int value = 0;
        s = s.Trim(); // Remove Whitespace
        if(s.Length == 0) return 0; // In case of empty string or only whitespaces

        // Get sign
        bool positive = true;
        int startIndex = 0;
        if (s[0] == '-') {positive = false; startIndex = 1;}
        if (s[0] == '+') startIndex = 1;
        if (startIndex > s.Length - 1) return 0;
        
        while (startIndex < s.Length && s[startIndex] == '0') startIndex++;// Skip leading zeros

        if (startIndex > s.Length - 1) return 0;

        // Convert to int
        for (int i = startIndex; i < s.Length; i++)
        {
            int digit = ConvertCharToInt(s[i]);
            if (digit == -1) break; // End if not valid

            // Check for bounds and see if return rounded value
            if (value > (INT_MAX - digit) / 10)
            {
                return positive ? INT_MAX : INT_MIN;
            }

            value = value * 10 + digit;
        }

        value = (positive) ? value : -value;

        return value;
    }

    int ConvertCharToInt(char digit)
    {
        switch (digit)
        {
            case '0': return 0;
            case '1': return 1;
            case '2': return 2;
            case '3': return 3;
            case '4': return 4;
            case '5': return 5;
            case '6': return 6;
            case '7': return 7;
            case '8': return 8;
            case '9': return 9;
            default: return -1;
        }
    }
}