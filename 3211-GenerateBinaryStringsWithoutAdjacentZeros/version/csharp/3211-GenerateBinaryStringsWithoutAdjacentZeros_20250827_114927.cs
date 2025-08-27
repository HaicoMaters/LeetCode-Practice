// Last updated: 27/08/2025, 11:49:27
public class Solution {
    public IList<string> ValidStrings(int n) {
        List<string> strings = new List<string>();
        GenerateStrings(n, false, "", strings);
        return strings;    
    }

    public void GenerateStrings(int length, bool wasZero, string current, List<string> strings)
    {
        if (current.Length == length)
        {
            strings.Add(current.ToString());
            return;
        }

        if(!wasZero)
        {
            GenerateStrings(length, true, current + "0", strings);
        }

        GenerateStrings(length, false, current + "1", strings);
    }
}