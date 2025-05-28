// Last updated: 28/05/2025, 13:14:07
public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> wordIndex = new List<int>();

        for (int i = 0; i < words.Length; i++)
        {
            foreach (char c in words[i])
            {
                if (c == x)
                {
                    wordIndex.Add(i);
                    break;
                }
            }
       }

       return wordIndex;
    }
}