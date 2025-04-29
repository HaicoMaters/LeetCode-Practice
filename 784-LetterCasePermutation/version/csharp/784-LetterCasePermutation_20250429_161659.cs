// Last updated: 29/04/2025, 16:16:59
public class Solution {
    List<string> permutations;
    public IList<string> LetterCasePermutation(string s) {
        permutations = new List<string>();
        BackTrack(s, 0, "");
        return permutations;
    }

    public void BackTrack(string original, int index, string current)
    {
        if (index == original.Length)
        {
            permutations.Add(current);
            return;
        }

        char c = original[index];

        BackTrack(original, index + 1, current + c); // original char

        if (char.IsLetter(c)) // include to opposite lower or upper case version
        {
            char toggled = char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c);
            BackTrack(original, index + 1, current + toggled);
        }
    }
}