public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longestLength = 0;
        int start = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            char currentChar = s[i];

            if (charIndexMap.ContainsKey(currentChar) && charIndexMap[currentChar] >= start) {
                start = charIndexMap[currentChar] + 1; 
            }

            charIndexMap[currentChar] = i;

            longestLength = Math.Max(longestLength, i-start+1);
        }

        return longestLength;
    }
}
