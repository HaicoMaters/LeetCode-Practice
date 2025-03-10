public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] shuffled = new char[s.Length];

        for (int i = 0; i < s.Length; i++){
            shuffled[indices[i]] = s[i];
        }

        return new string(shuffled);
    }
}