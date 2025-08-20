// Last updated: 20/08/2025, 11:45:59
public class Solution {
    HashSet<string> dict;

    public string ReplaceWords(IList<string> dictionary, string sentence) {
        dict = new HashSet<string>(dictionary);

        string[] words = sentence.Split(' ');

        for(int i = 0; i < words.Length; i++)
        {
            words[i] = GetShortestRoot(words[i]);
        }

        return string.Join(" ", words);
    }

    public string GetShortestRoot(string word)
    {
        for (int i = 1; i <= word.Length; i++)
        {
            string root = word.Substring(0, i);

            if (dict.Contains(root)) return root;
        }

        return word;
    }
}