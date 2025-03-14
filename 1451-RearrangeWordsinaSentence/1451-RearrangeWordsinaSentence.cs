public class Solution {
    public string ArrangeWords(string text) {
        
        string[] words = text.ToLower().Split(" ");
        StringBuilder sb = new StringBuilder(string.Join(" ", words.OrderBy(t => t.Length)));
        sb[0] = char.Parse(sb[0].ToString().ToUpper());
        return sb.ToString();
    }
}