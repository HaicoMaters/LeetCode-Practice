// Last updated: 15/07/2025, 11:04:42
public class Solution {
    public bool IsValid(string word) {
        
        if (word.Length < 3) return false;

        bool hasVowel = false;
        bool hasConsonant = false;

        foreach (char c in word)
        {
            if (char.IsLetter(c))
            {
                char ch = char.ToLower(c);

                // vowel check
                switch (ch)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        hasVowel = true;
                        break;
                    default:
                        hasConsonant = true;
                        break;
                }
            }
            else if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return hasVowel && hasConsonant;
    }
}