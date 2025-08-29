// Last updated: 29/08/2025, 11:43:53
public class Solution {
    public long FlowerGame(int n, int m) {
        /// if 1 lane has odd and one lane has even number of flowers Alice will win this should happen half of the time
        return (long)n*m/2;
    }
}