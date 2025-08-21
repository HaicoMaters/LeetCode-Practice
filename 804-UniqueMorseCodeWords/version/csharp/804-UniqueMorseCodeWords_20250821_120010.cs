// Last updated: 21/08/2025, 12:00:10
public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        string[] letters = new string[]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."}; // all the letters in morse code

        HashSet<string> transformations = new HashSet<string>();

        foreach (string word in words)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in word)
            {
                sb.Append(letters[c - 'a']);
            }
            transformations.Add(sb.ToString());
        }

        return transformations.Count;
    }
}