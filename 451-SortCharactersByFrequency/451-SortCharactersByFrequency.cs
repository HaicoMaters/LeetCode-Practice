public class Solution {
    public string FrequencySort(string s) {
        var frequency = new Dictionary<char, int>();

        // Get frequency of each char
        foreach (char c in s)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]++;
            }
            else
            {
                frequency.Add(c, 1);
            }
        }

        // Get sorted by number of apperances
        var sortedChars = frequency.OrderByDescending(x => x.Value);

        // Build the string
        var sortedString = new StringBuilder();
        foreach (var kvp in sortedChars)
        {
            sortedString.Append(kvp.Key, kvp.Value);
        }
        return sortedString.ToString();
    }
}