public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {

        var sequences = new Dictionary<string, int>(); //Existing sequences
        List<string> repeated = new List<string>();

        for (int i = 0; i < s.Length - 9; i++)
        {
            string sub = s.Substring(i, 10);
            if (!sequences.ContainsKey(sub))
            {
                sequences.Add(sub, 1);
            }
            else
            {
                if (sequences[sub] == 1) repeated.Add(sub);
                sequences[sub]++;
            }
        }

        return repeated;
    }
}