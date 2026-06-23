// Last updated: 23/06/2026, 10:38:56
1public class Solution {
2    public int MaxIceCream(int[] costs, int coins) { // required to solve by counting sort as per question
3        int[] sorted = CountingSort(costs);
4
5        int maxIce = 0;
6
7        foreach (int cost in sorted)
8        {
9            if (coins >= cost)
10            {
11                maxIce++;
12                coins -= cost;
13            }
14            else
15            {
16                break;
17            }
18        }
19
20        return maxIce;
21    }
22
23    public int[] CountingSort(int[] arr) // efficent when the range of input values is small compared to the number of elements to be sorted
24    {
25        int n = arr.Length;
26        int max = arr[0];
27
28        // find max val
29        for (int i = 1; i < n; i++)
30        {
31            if (arr[i] > max)
32            {
33                max = arr[i];
34            }
35        }
36
37        // get occurances of each value
38        int[] countArr = new int[max + 1];
39        foreach (int val in arr)
40        {
41            countArr[val]++;
42        }
43
44        // prefix sum
45        for (int i = 1; i <= max; i++)
46        {
47            countArr[i] += countArr[i-1];
48        }
49
50        int[] sorted = new int[n];
51        for (int i = n-1; i >= 0; i--)
52        {
53            int val = arr[i];
54            sorted[countArr[val] - 1] = val;
55            countArr[val]--; 
56        }
57
58        return sorted;
59    }
60}