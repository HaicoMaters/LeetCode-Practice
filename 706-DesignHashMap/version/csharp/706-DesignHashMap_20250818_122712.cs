// Last updated: 18/08/2025, 12:27:12
public class MyHashMap {
    public int[] values = new int[1000001]; // keys range from 0 to 10^6 // so can just do this and all values are value + 1 where zero would be -1 aka not existing

    public MyHashMap() {

    }
    
    public void Put(int key, int value) {
        values[key] = value + 1;
    }
    
    public int Get(int key) {
        return values[key] - 1;
    }
    
    public void Remove(int key) {
        values[key] = 0;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */