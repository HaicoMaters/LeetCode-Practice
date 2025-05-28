// Last updated: 28/05/2025, 13:17:24
public class Solution {
    HashSet<(int x, int y)> triedStates; // for memoization to not try solving repeated states

    public bool CanMeasureWater(int x, int y, int target) {
        if (target > x + y) return false;

        triedStates = new HashSet<(int x, int y)>();

        return SolveStates(x, y, 0, 0, target);
    }

    public bool SolveStates(int x, int y, int fillX, int fillY, int target)
    {
        if (fillX + fillY == target) return true;

        if (triedStates.Contains((fillX, fillY))) return false;

        triedStates.Add((fillX, fillY));

        bool solved = false;

        // Generate states with trying by filling jug x completly
        if (fillX < x)
        {
            solved = solved || SolveStates(x, y, x, fillY, target);
        }
        
        // Generate states with trying by filling jug y completly
        if (!solved && fillY < y)
        {
            solved = solved || SolveStates(x, y, fillX, y, target);
        }

        // Generate states with trying by emptying jug x completly
        if (!solved && fillX > 0)
        {
            solved = solved || SolveStates(x, y, 0, fillY, target);
        }

        // Generate states with trying by emptying jug y completly
        if (!solved && fillY > 0)
        {
            solved = solved || SolveStates(x, y, fillX, 0, target);
        }

        // Generate states with trying by pouring jug x into jug y
        if (!solved && fillX > 0 && fillY < y)
        {
            int amountPoured = Math.Min(fillX, y - fillY);
            solved = solved || SolveStates(x, y, fillX - amountPoured, fillY + amountPoured, target);
        }

        // Generate states with trying by pouring jug y into jug x
        if (!solved && fillY > 0 && fillX < x)
        {
            int amountPoured = Math.Min(fillY, x - fillX);
            solved = solved || SolveStates(x, y, fillX + amountPoured, fillY - amountPoured, target);
        }

        return solved;
    }
}