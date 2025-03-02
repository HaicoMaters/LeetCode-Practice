public class Solution {
    public IList<string> GenerateParenthesis(int n) { // Backtracking solution
        IList<string> combinations = new List<string>();
        GenerateParenthesis(n, combinations, "", 0, 0);
        return combinations;
    }

    public void GenerateParenthesis(int n, IList<string> combinations, string current, int open, int closed)
    {
        if (current.Length == 2 * n)
        {
            combinations.Add(current);
            return;
        }

        // Do an version with a closed next
        if (open > closed)
        {
            GenerateParenthesis(n, combinations, current + ")", open, closed + 1);
        }
        
        // Do another open if not yet n pairs of open
        if (open < n)
        {
            GenerateParenthesis(n, combinations, current + "(", open + 1, closed);
        }
    }
}