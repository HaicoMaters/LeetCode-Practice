// Last updated: 09/11/2026, 10:09:27
1public class Solution {
2    public IList<int> BusiestServers(int k, int[] arrival, int[] load) {
3        List<int> busiest = new List<int>();
4        int[] requestCount = new int[k];
5        PriorityQueue<int, int> free = new PriorityQueue<int, int>();
6        PriorityQueue<(int,int), int> busy = new PriorityQueue<(int,int), int>();
7
8        // servers start free
9        for (int i = 0; i < k; i++)
10        {
11            free.Enqueue(i,i);
12        }
13
14        for (int i = 0; i < arrival.Length; i++)
15        {
16            int start = arrival[i];
17
18            // free up busy servers
19            while (busy.Count > 0 && busy.Peek().Item1 <= start)
20            {
21                var current = busy.Dequeue();
22                int id = current.Item2;
23                int nId = ((id-i) % k + k)%k + i;
24                free.Enqueue(nId, nId);
25            }
26
27            // get original id from new id and enqueue new requests
28            if (free.Count > 0)
29            {
30                int id = free.Dequeue()%k;
31                busy.Enqueue((start+load[i], id), start+load[i]);
32                requestCount[id]++;
33            }
34        }
35
36        // find value of busiest servers
37        int max = requestCount[0];
38        for (int i = 1; i < k; i++)
39        {
40            max = Math.Max(max, requestCount[i]);
41        }
42
43        // get all of the busiest servers
44        for (int i = 0; i < k; i++)
45        {
46            if (max == requestCount[i])
47            {
48                busiest.Add(i);
49            }
50        }
51
52        return busiest;
53    }
54}