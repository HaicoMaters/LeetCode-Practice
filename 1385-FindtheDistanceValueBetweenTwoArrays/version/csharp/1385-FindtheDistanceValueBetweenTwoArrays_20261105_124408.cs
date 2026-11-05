// Last updated: 05/11/2026, 12:44:08
1public class Solution {
2    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
3        Array.Sort(arr2);
4        int dist = 0;
5
6        foreach (int num in arr1)
7        {
8            int start = num - d;
9            int end = num + d;
10
11            if (!IsValid(arr2, start, end)) // valid is where elements arr1[i]-arr2[j] <= d
12            {
13                dist++;
14            }
15        }
16
17        return dist;
18    }
19
20    // using binary search to check validity
21    public bool IsValid(int[] arr, int start, int end)
22    {
23        int L = 0;
24        int R = arr.Length - 1;
25
26        while (L <= R)
27        {
28            int mid = (L + R)/2;
29
30            if (arr[mid] >= start && arr[mid] <= end) return true;
31
32            if (arr[mid] < start)
33            {
34                L = mid + 1;
35            }
36            else
37            {
38                R = mid - 1;
39            }
40        }
41
42        return false;
43    }
44}