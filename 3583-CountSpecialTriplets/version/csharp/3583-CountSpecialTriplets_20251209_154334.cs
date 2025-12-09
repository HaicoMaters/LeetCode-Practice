// Last updated: 09/12/2025, 15:43:34
1public class Solution {
2    public int SpecialTriplets(int[] nums) {
3        const int MOD = 1000000007;
4        long triplets = 0;
5        Dictionary<int, int> freqRight = new Dictionary<int, int>();
6        Dictionary<int, int> freqLeft = new Dictionary<int, int>();
7
8        foreach (int num in nums)
9        {
10            if(!freqRight.ContainsKey(num)){
11                freqRight[num] = 0;
12            }
13            freqRight[num]++;
14        }
15
16        for (int i = 0; i < nums.Length; i++)
17        {
18            freqRight[nums[i]]--;
19
20            int target = nums[i] * 2;
21            long right = freqRight.GetValueOrDefault(target);
22            long left = freqLeft.GetValueOrDefault(target);
23            triplets = (triplets + (right * left)) % MOD;
24
25            if(!freqLeft.ContainsKey(nums[i]))
26            {
27                freqLeft[nums[i]] = 0;
28            }
29            freqLeft[nums[i]]++;
30        }
31
32        return (int)triplets;
33    }
34}