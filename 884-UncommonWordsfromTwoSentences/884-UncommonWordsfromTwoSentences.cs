public class Solution {

    Dictionary<string, int> wordCount;

    public string[] UncommonFromSentences(string s1, string s2) {

        wordCount = new Dictionary<string, int>();

        // Add string to dicionary
        updateDict(s1);
        updateDict(s2);

        List<string> uncommon = new List<string>();
        foreach (var word in wordCount)
        {
            if (word.Value == 1)
            {
                uncommon.Add(word.Key);
            }
        }

        return uncommon.ToArray();
    }

    public void updateDict(string s)
    {
        string[] words = s.Split(' '); // splitBySpace

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }
    }
}