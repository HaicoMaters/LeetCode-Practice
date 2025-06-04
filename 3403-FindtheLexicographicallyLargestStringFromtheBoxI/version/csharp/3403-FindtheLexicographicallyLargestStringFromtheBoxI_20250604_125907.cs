// Last updated: 04/06/2025, 12:59:07
public class Solution {
    public string AnswerString(string word, int numFriends) {
        // Find the starting index of the lexicographically largest substring prefix,
        // then find the longest substring possible with that num friends length (n - numFriends + 1)

        int n = word.Length;

        if (numFriends == 1) return word;
        
        int bestStart = 0;
        int start = 1;

        while (start < n)
        {
            int length = 1;
            
            // continue increasing length as long as it is the same as the current lexicographically largest string
            while (start + length <= n && word[bestStart + length - 1] == word[start + length - 1])
            {
                length++;
            }

            if (start + length <= n && word[bestStart + length - 1] < word[start + length - 1]) // better substring found replace start
            {
                int temp = bestStart;
                bestStart = start;
                // Skip all overlapping substrings that are not better (want longest with that as a prefix)
                start = Math.Max(start + 1, temp + length);  
            }
            else
            {
                start += length; // smaller substring, look for new better strings
            }
        }

        return word.Substring(bestStart, Math.Min(n - bestStart, n - numFriends + 1));
    }
}