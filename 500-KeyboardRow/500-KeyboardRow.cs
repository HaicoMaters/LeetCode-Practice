public class Solution {
    public string[] FindWords(string[] words) {
        string row1 = "qwertyuiop";
        string row2 = "asdfghjkl";
        string row3 = "zxcvbnm";
        List<string> found = new List<string>();


        foreach (string word in words)
        {
            if (AllInSameRow(row1, word) || AllInSameRow(row2, word) || AllInSameRow(row3, word)) 
            {
                found.Add(word);
            }
        }

        return found.ToArray();
    }

    bool AllInSameRow(string row, string word) 
    {
        word = word.ToLower();
        foreach (char c in word) 
        {
            if (!row.Contains(c)) return false;
        }
        return true; 
    }
}