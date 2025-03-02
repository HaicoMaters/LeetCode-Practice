/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        // Binary search 
        int L = 1, R = n;
        bool solved = false;
        while (L <= R)
        {
            int mid = L + (R - L)/2; 
            int result = guess(mid);
            if (result == 0) return mid;
            if(result == -1)
            {
                R = mid - 1;
            }
            else
            {
                L = mid + 1;
            }
        }
        return -1;
    }
}