// Last updated: 28/05/2025, 13:15:57
public class Solution {
    public string PushDominoes(string dominoes) {
        int n = dominoes.Length;
        int[] forces = new int[n];

        // Sweep from left to right
        int force = 0;
        for (int i = 0; i < n; i++) 
        {
            if (dominoes[i] == 'R') 
            {
                force = n;
            } else if (dominoes[i] == 'L') 
            {
                force = 0;
            } else if (force > 0) 
            {
                force--;
            }
            forces[i] += force;
        }

        // Sweep from right to left
        force = 0;
        for (int i = n - 1; i >= 0; i--) 
        {
            if (dominoes[i] == 'L') 
            {
                force = n;
            } 
            else if (dominoes[i] == 'R') 
            {
                force = 0;
            } 
            else if (force > 0) 
            {
                force--;
            }
            forces[i] -= force;
        }

        // Build string from resulting forces
        var result = new StringBuilder();
        foreach (var f in forces) 
        {
            if (f > 0) result.Append('R');
            else if (f < 0) result.Append('L');
            else result.Append('.');
        }

        return result.ToString();
    }
}