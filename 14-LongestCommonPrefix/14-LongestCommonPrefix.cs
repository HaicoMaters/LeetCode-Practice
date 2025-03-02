public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0)
            return "";

        string currentPrefix = strs[0];

        for (int i = 1; i < strs.Length; i++) {
            int sharedLength = 0;

            while (sharedLength < currentPrefix.Length && sharedLength < strs[i].Length && currentPrefix[sharedLength] == strs[i]
            [sharedLength]) {
                sharedLength++;
            }

            currentPrefix = currentPrefix.Substring(0, sharedLength);

            if (currentPrefix == "")
                return "";
        }

        return currentPrefix;
    }
}
