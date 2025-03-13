public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int most = 0;

        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] > most){
                most = candies[i];
            }
        }

        List<bool> result = new List<bool>();

        foreach (int kid in candies){
            result.Add(kid + extraCandies >= most);
        }

        return result;
    }
}