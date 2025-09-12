// Last updated: 12/09/2025, 11:13:35
public class Solution {
    public bool DoesAliceWin(string s) { // wins as long as at least one vowel
        HashSet<char> vowels = new HashSet<char>("aeiou");
        foreach (char c in s)
        {
            if (vowels.Contains(c)) return true;
        }
        return false;
    }
}