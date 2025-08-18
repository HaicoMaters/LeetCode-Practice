// Last updated: 18/08/2025, 12:21:21
public class MyHashSet {
    private bool[] set = new bool[1000001]; // keys range from 0 to 10^6 // so can just do this

    public MyHashSet() {
        
    }
    
    public void Add(int key) {
        set[key] = true;
    }
    
    public void Remove(int key) {
        set[key] = false;
    }
    
    public bool Contains(int key) {
        return set[key];
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */