// Last updated: 23/11/2026, 10:03:48
1public class ProductOfNumbers {
2    public List<int> prod;
3
4    public ProductOfNumbers() {
5        prod = new List<int>{1};
6    }
7    
8    public void Add(int num) {
9        if (num == 0) 
10        {
11            prod.Clear();
12            prod.Add(1);
13        }
14        else
15        {
16            int last = prod[prod.Count-1];
17            prod.Add(last * num);
18        }
19    }
20    
21    public int GetProduct(int k) {
22        int len = prod.Count;
23        if (k >= len) return 0;
24
25        return prod[len-1] / prod[len-k-1];
26    }
27}
28
29/**
30 * Your ProductOfNumbers object will be instantiated and called as such:
31 * ProductOfNumbers obj = new ProductOfNumbers();
32 * obj.Add(num);
33 * int param_2 = obj.GetProduct(k);
34 */