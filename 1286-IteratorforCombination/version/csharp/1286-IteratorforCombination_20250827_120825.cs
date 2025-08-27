// Last updated: 27/08/2025, 12:08:25
public class CombinationIterator {
    List<string> combinations;
    int currentCombo;


    public CombinationIterator(string characters, int combinationLength) {
        combinations = new List<string>();
        currentCombo = 0;
        GenerateCombinations(0, "", characters, combinationLength);
    }

    public void GenerateCombinations(int index, string combo, string chars, int length)
    {
        if (combo.Length == length)
        {
            combinations.Add(combo);
            return;
        }

        for (int i = index; i < chars.Length; i++)
        {
            GenerateCombinations(i+1, combo + chars[i], chars, length);
        }
    }
    
    public string Next() {
        return combinations[currentCombo++];
    }
    
    public bool HasNext() {
        return currentCombo < combinations.Count;
    }
}

/**
 * Your CombinationIterator object will be instantiated and called as such:
 * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
 * string param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */