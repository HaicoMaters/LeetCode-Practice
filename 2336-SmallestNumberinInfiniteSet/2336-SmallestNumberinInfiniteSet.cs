// Last updated: 08/03/2025, 13:57:54
public class SmallestInfiniteSet {
    
    int nextToAdd;
    SortedSet<int> set;

    public SmallestInfiniteSet() {
        set = new SortedSet<int>(); 
        nextToAdd = 1;
    }
    
    public int PopSmallest() {
        if (set.Count > 0) {
            int smallest = set.Min;
            set.Remove(smallest);
            return smallest;
        }
        return nextToAdd++;
    }
    
    public void AddBack(int num) {
        if (num < nextToAdd) { // Only add back if it was previously popped
            set.Add(num);
        }
    }
}


/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */