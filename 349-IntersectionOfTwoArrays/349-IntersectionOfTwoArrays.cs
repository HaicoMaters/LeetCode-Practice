// Last updated: 28/05/2025, 13:17:26
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> possible = new HashSet<int>();
        HashSet<int> intersections = new HashSet<int>();

        foreach (int num in nums1){
            possible.Add(num);
        }

        foreach (int num in nums2){
            if (possible.Contains(num)){
                intersections.Add(num);
            }
        }

        return intersections.ToArray();
    }
}