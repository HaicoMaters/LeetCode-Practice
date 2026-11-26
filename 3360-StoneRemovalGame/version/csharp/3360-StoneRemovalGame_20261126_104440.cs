// Last updated: 26/11/2026, 10:44:40
1public class Solution {
2    public bool CanAliceWin(int n) {
3        bool win = false;
4        int remove = 10;
5
6        while(n >= remove)
7        {
8            win = !win;
9            n -= remove;
10            remove--;
11        }
12
13        return win;
14    }
15}