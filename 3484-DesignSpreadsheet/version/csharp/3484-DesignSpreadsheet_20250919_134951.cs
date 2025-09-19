// Last updated: 19/09/2025, 13:49:51
public class Spreadsheet {
    Dictionary<string, int> cells;
    int rows;

    public Spreadsheet(int rows) {
        this.rows = rows;
        cells = new Dictionary<string, int>();
    }
    
    public void SetCell(string cell, int value) {
        cells[cell] = value;
    }
    
    public void ResetCell(string cell) {
        cells.Remove(cell);
    }
    
    public int GetValue(string formula) {
        string[] parts = formula.Substring(1).Split('+'); // skip the first char (= sign)

        // check if int or not
        bool int1 = int.TryParse(parts[0], out int a);
        bool int2 = int.TryParse(parts[1], out int b);

        int val = 0;
        val += (int1) ? a : cells.GetValueOrDefault(parts[0], 0);
        val += (int2) ? b : cells.GetValueOrDefault(parts[1], 0);
        return val;
    }
}

/**
 * Your Spreadsheet object will be instantiated and called as such:
 * Spreadsheet obj = new Spreadsheet(rows);
 * obj.SetCell(cell,value);
 * obj.ResetCell(cell);
 * int param_3 = obj.GetValue(formula);
 */