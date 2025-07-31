// Last updated: 31/07/2025, 13:13:54
public class Solution {
    public int SubarrayBitwiseORs(int[] arr) {
        HashSet<int> ORs = new HashSet<int>();
        HashSet<int> current = new HashSet<int>(); // contains the ors of each subarray ORed with last num up till current

        foreach(int num in arr)
        {
            HashSet<int> next = new HashSet<int>{num};
            foreach (int x in current)
            {
                next.Add(x | num); // OR with previous results
            }

            current = next;
            foreach (int x in current)
            {
                ORs.Add(x);
            }
        }

        return ORs.Count;
    }
}