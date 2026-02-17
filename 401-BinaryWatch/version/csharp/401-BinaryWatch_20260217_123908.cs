// Last updated: 17/02/2026, 12:39:08
1public class Solution {
2    int[] hours = new int[]{1, 2, 4, 8};
3    int[] minutes = new int[]{1, 2, 4, 8, 16, 32};
4    List<string> times;
5
6    public IList<string> ReadBinaryWatch(int turnedOn) {
7        times = new List<string>();
8        if (turnedOn >= 9) return times; // no valid combinations
9        GetPossibleTimes(0, 0, 0, turnedOn);
10        return times;
11    }
12
13    public void GetPossibleTimes(int hour, int minute, int start, int remainingBits)
14    {
15        if (remainingBits == 0)
16        {
17            times.Add($"{hour}:{minute:D2}");
18            return;
19        }
20
21        for (int i = start; i < 10; i++)
22        {
23            if (i <= 3)
24            {
25                if (hour + hours[i] <= 11)
26                {
27                    GetPossibleTimes(hour + hours[i], minute, i+1, remainingBits-1);
28                }
29            }
30            else
31            {
32                if (minute + minutes[i-4] <= 59)
33                {
34                    GetPossibleTimes(hour, minute + minutes[i-4], i+1, remainingBits-1);
35                }
36            }
37        }
38    }
39}