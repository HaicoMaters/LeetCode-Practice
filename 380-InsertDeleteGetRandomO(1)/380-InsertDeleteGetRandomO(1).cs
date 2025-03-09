public class RandomizedSet {

    Dictionary<int, int> dict; // Maps value -> index in list
    List<int> list;            // Stores values
    Random rand;

    public RandomizedSet() {
        dict = new Dictionary<int, int>();
        list = new List<int>();
        rand = new Random();
    }
    
    public bool Insert(int val) {
        if (dict.ContainsKey(val)) return false;
        dict[val] = list.Count;
        list.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if (!dict.ContainsKey(val)) return false;

        int index = dict[val];
        int lastElement = list[list.Count - 1];

        // Swap last element with the element to be removed
        list[index] = lastElement;
        dict[lastElement] = index;

        // Remove last element
        list.RemoveAt(list.Count - 1);
        dict.Remove(val);
        
        return true;
    }
    
    public int GetRandom() {
        return list[rand.Next(list.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */