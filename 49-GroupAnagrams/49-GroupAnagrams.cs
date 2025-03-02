public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> groups = new Dictionary<string, IList<string>>();
        
        foreach (string str in strs) 
        {
            string sortedStr = SortString(str); // Use sorted string as a key
            if (!groups.ContainsKey(sortedStr)) groups[sortedStr] = new List<string>(); // Add new group
            groups[sortedStr].Add(str); // Add to the relevant group
        }
        
        return new List<IList<string>>(groups.Values);
    }
    
    private string SortString(string s) {
        char[] charArray = s.ToCharArray();
        Array.Sort(charArray);
        return new string(charArray);
    }
}