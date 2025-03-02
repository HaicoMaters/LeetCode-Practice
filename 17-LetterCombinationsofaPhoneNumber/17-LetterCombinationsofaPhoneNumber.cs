public class Solution {
    public IList<string> LetterCombinations(string digits) {
        
        List<string> combos = new List<string>();
        if (digits == null || digits == "" || digits == "1")
        {
            return combos;
        }
        
        // 2 -> index: 0-2, 3 -> index: 3-5 etc. 7 is index 15-18
        string chars = "abcdefghijklmnopqrstuvwxyz";
        string possibleChars = "";

        // Get All possible Characters
        for (int i = 0; i < digits.Length; i++)
        {
            int digit = (int)char.GetNumericValue(digits[i]);
            int startIndex = GetStartIndex(digit);

            if (startIndex < 0)
            {
                continue;
            }

            // Handle the first digit
            if (i == 0)
            {
                combos.Add(chars[startIndex].ToString());
                combos.Add(chars[startIndex + 1].ToString());
                combos.Add(chars[startIndex + 2].ToString());
                if(digit == 7 || digit == 9) // The unique case digit is 7 or 9
                {
                    combos.Add(chars[startIndex + 3].ToString());
                }
                continue;
            }

            int originalComboCount = combos.Count;
            // Update Possible Combos
            for (int j = 0; j < originalComboCount; j++)
            {
                combos.Add(combos[j] + chars[startIndex + 1]);
                combos.Add(combos[j] + chars[startIndex + 2]);
                if (digit == 7 || digit == 9) // The unique case digit is 7 or 9
                {
                    combos.Add(combos[j] + chars[startIndex + 3]);

                }
                combos[j] = combos[j] + chars[startIndex];
            }
        }
        return combos;
    }

    public int GetStartIndex(int digit)
    {
        int startIndex;
        if(digit < 2)
        { 
            return -1;
        }
        startIndex = 3 * (digit - 2);
        if(digit > 7) // one extra number above 7
        {
            startIndex++;
        }
        return startIndex;
    }
}