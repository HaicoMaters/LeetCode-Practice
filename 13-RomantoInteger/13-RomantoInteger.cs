public class Solution {
    public int RomanToInt(string s) {
        int sum = 0;
        int lastValue = 0; // For comparision  e.g. IV mobing backwards last value V minus value I so 4 can be gotten correctly

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int current = RomanNumerals(s[i]);
            if (current < lastValue)
            {
                sum -= current;
            }
            else 
            {
                sum += current;
            }
            lastValue = current;
        }

        return sum;
    }

        public int RomanNumerals(char c)
    {
        switch(c){
            case 'I' : return 1;
            case 'V' : return 5;
            case 'X' : return 10;
            case 'L' : return 50;
            case 'C' : return 100;
            case 'D' : return 500;
            case 'M' : return 1000;
        };  
        return 0;
    }
}