public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length == 0) {
            return 0;
        }

        if (needle.Length > haystack.Length) {
            return -1;
        }

        for (int i = 0; i <= haystack.Length - needle.Length; i++) {
            bool match = true;
            for (int j = 0; j < needle.Length; j++) {
                if (haystack[i + j] != needle[j]) {
                    match = false;
                    break;
                }
            }

            if (match) {
                return i;
            }
        }
        
        return -1;
    }
}
