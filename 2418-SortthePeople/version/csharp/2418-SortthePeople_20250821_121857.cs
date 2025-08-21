// Last updated: 21/08/2025, 12:18:57
public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        int n = names.Length;

        (string Name, int Height)[] people = new (string, int)[n];
        
        for (int i = 0; i < n; i++)
        {
            people[i] = (names[i], heights[i]);
        }

        Array.Sort(people, (a,b) => b.Height.CompareTo(a.Height));

        string[] sorted = new string[n];

        for (int i = 0; i < n; i++)
        {
            sorted[i] = people[i].Name;
        }

        return sorted;
    }
}