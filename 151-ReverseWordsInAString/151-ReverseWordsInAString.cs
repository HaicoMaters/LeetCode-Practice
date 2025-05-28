// Last updated: 28/05/2025, 13:18:01
public class Solution {
    public string ReverseWords(string s) {
        s = s.Trim(); // Remove extra whitespace trailing and leading
        string[] words = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries); // split by spaces
        Array.Reverse(words); // reverse the words

        return string.Join(" ", words); // join as a single string
    }
}