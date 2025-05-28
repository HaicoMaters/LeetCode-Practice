// Last updated: 28/05/2025, 13:16:50
public class RandomizedCollection {

    private Dictionary<int, HashSet<int>> numIndices;  // Value -> Set of Indices
    private List<int> nums;  // List of inserted numbers
    private Random rand;

    public RandomizedCollection() {
        nums = new List<int>();
        numIndices = new Dictionary<int, HashSet<int>>();
        rand = new Random();
    }

    public bool Insert(int val) {
        bool alreadyExists = numIndices.ContainsKey(val);

        if (!alreadyExists) {
            numIndices[val] = new HashSet<int>();
        }

        numIndices[val].Add(nums.Count);
        nums.Add(val);

        return !alreadyExists;
    }

    public bool Remove(int val) {
        if (!numIndices.ContainsKey(val) || numIndices[val].Count == 0) {
            return false;
        }

        int removeIndex = numIndices[val].First();
        numIndices[val].Remove(removeIndex);

        // If removing the last element, no need to swap
        int lastIndex = nums.Count - 1;
        if (removeIndex != lastIndex) { // swap index with element at end and re-add to dict with index of the removed one
            int lastVal = nums[lastIndex];

            nums[removeIndex] = lastVal;

            numIndices[lastVal].Remove(lastIndex);
            numIndices[lastVal].Add(removeIndex);
        }

        nums.RemoveAt(lastIndex);

        if (numIndices[val].Count == 0) {
            numIndices.Remove(val);
        }

        return true;
    }

    public int GetRandom() {
        int index = rand.Next(0, nums.Count);
        return nums[index];
    }
}

/**
 * Your RandomizedCollection object will be instantiated and called as such:
 * RandomizedCollection obj = new RandomizedCollection();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */