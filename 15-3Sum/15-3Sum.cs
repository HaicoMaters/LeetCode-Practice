public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        HashSet<(int, int, int)> triplets = new HashSet<(int, int, int)>();

        // Populate the dictionary with number of occurances
        foreach (int num in nums) {
            if (numbers.ContainsKey(num)) {
                numbers[num]++;
            } else {
                numbers[num] = 1;
            }
        }

        var uniqueNums = numbers.Keys.ToList();
        uniqueNums.Sort();

        for (int i = 0; i < uniqueNums.Count; i++) {
            int x = uniqueNums[i];
            numbers[x]--;

            for (int j = i; j < uniqueNums.Count; j++) {
                int y = uniqueNums[j];

                if (numbers[y] <= 0) {
                    continue;
                }

                int z = -(x + y);

                if (numbers.ContainsKey(z) && numbers[z] > 0) {
                    if ((z == y && numbers[y] < 2) || (z == x && numbers[x] < 1)) {
                        continue;
                    }

                    // Ensure triplet is always sorted
                    var triplet = (Math.Min(x, Math.Min(y, z)), 
                                   Math.Max(Math.Min(x, y), Math.Min(Math.Max(x, y), z)), 
                                   Math.Max(x, Math.Max(y, z)));
                    
                    triplets.Add(triplet);
                }
            }
            numbers[x]++;
        }
        // Convert HashSet to correct format
        return triplets.Select(t => (IList<int>)new List<int> { t.Item1, t.Item2, t.Item3 }).ToList();
    }
}
