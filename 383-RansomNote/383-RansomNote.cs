public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> availableLetters = new Dictionary<char, int>();
        
        // Get all useable letters
        foreach (char c in magazine)
        {
            if (availableLetters.ContainsKey(c))
            {
                availableLetters[c]++;
            }
            else
            {
                availableLetters.Add(c, 1);
            }
        }

        foreach (char c in ransomNote)
        {
            if(availableLetters.ContainsKey(c))
            {
                if (availableLetters[c] > 0) availableLetters[c]--;
                else return false;
            }
            else return false;
        }

        return true;
    }
}