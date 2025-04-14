// Last updated: 14/04/2025, 16:10:15
public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        int first = ConvertWordToNumericalValue(firstWord);
        int second = ConvertWordToNumericalValue(secondWord);
        int target = ConvertWordToNumericalValue(targetWord);

        return first + second == target;
    }

    public int ConvertWordToNumericalValue(string s)
    {
        int mult = 1;
        int value = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            value += mult * (s[i] - 'a');
            mult *= 10;
        }

        return value;
    }
}