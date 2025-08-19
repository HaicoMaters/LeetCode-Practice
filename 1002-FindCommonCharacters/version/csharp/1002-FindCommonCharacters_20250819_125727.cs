// Last updated: 19/08/2025, 12:57:27
public class Solution {
    public IList<string> CommonChars(string[] words) {
        int[] freq = new int[26];
        int[] freq2 = new int[26];

        List<string> commonChars = new List<string>();
    
        foreach(char c in words[0])
        {
            freq[c - 'a']++;
        }

        for (int i = 1; i < words.Length; i++)
        {

            foreach (char c in words[i])
            {
                freq2[c - 'a']++;
            }

            for (int j = 0; j < 26; j++) // get rid of uncommon characters and reset freq2 array
            {
                freq[j] = Math.Min(freq[j], freq2[j]);
                freq2[j] = 0;
            }
        }

        for (int i = 0; i < 26; i++)
        {
            char c = (char)(i + 'a');
            while (freq[i] > 0)
            {
                commonChars.Add(c.ToString());
                freq[i]--;
            }
        }

        return commonChars;
    }
}