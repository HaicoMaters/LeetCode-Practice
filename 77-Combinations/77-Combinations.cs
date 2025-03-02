public class Solution {

    List<IList<int>> combinations = new List<IList<int>>();

    public IList<IList<int>> Combine(int n, int k) {
        Combine(n, k, 1, new List<int>());
        return combinations;
    }

    public void Combine(int n, int k, int start, List<int> combo)
    {
        if (combo.Count == k)
        {
            combinations.Add(new List<int>(combo));
            return;
        }

        for(int i = start; i <= n; i++)
        {
            combo.Add(i);
            Combine(n, k, i+1, combo);
            combo.RemoveAt(combo.Count - 1);
        }
    }
}