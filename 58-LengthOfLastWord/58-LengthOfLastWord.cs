// Last updated: 28/05/2025, 13:18:39
public class Solution {
    public int LengthOfLastWord(string s) {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (words.Length == 0) return 0;
        return words[words.Length - 1].Length;
    }
}