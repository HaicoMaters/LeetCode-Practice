// Last updated: 24/06/2026, 08:21:19
1public class Solution {
2    const long mod = 1000000007;
3
4    public int ZigZagArrays(int n, int l, int r) {
5        int m = r - l + 1;
6
7        if (n == 1) return m % (int)mod;
8
9        int size = 2 * m; // 0 -> m - 1 = last was increasing. m - > 2*m - 1 last was increasing
10
11        long[,] transitionMatrix = new long[size, size];
12
13        for (int j = 0; j < m; j++)
14        {
15            for (int i = 0; i < j; i++) // where i < j sum of number of zigzag arrays ending at j where j was decreasing
16            {
17                transitionMatrix[j, m + i] = 1;
18            }
19
20            for (int i = j+1; i < m; i++) // where i > j sum of zigzag arrays ending at j where j was increasing
21            {
22                transitionMatrix[m + j, i] = 1;
23            }
24        }
25
26        long[] state = new long[size];
27        for (int i = 0; i < size; i++)
28        {
29            state[i] = 1;
30        }
31
32        long[] result = MatrixVectorMultiplication(MatrixExp(transitionMatrix, n - 1), state);
33
34        long count = 0;
35        foreach (long value in result) count = (count + value) % mod;
36        return (int)count;
37    }
38
39    // -------------------- Matrix Operations -------------------------------------
40    public long[,] MatrixMultiplication(long[,] matrix1, long[,] matrix2){ // for two square matrices of equal sizes
41        int size = matrix1.GetLength(0);
42        long[,] result = new long[size,size];
43
44        for (int i = 0; i < size; i++)
45        {
46            for (int j = 0; j < size; j++)
47            {
48                for (int k = 0; k < size; k++)
49                {
50                    result[i,j] = ((result[i,j] + matrix1[i, k] * matrix2[k, j])) % mod;
51                }
52            }
53        }
54
55        return result;
56    }
57
58    public long[,] MatrixExp(long[,] matrix, long exp)
59    {
60        int size = matrix.GetLength(0);
61
62        long[,] result = new long[size,size];
63
64        for (int i = 0; i < size; i++) // create identity matrix
65        {
66            result[i,i] = 1;
67        }
68
69        while (exp > 0)
70        {
71            if((exp & 1) == 1) result = MatrixMultiplication(result, matrix);
72            matrix = MatrixMultiplication(matrix, matrix);
73            exp >>= 1;
74        }
75
76        return result;
77    }
78
79    long[] MatrixVectorMultiplication(long[,] matrix, long[] vector)
80    {
81        int size = vector.Length;
82        long[] result = new long[size];
83
84        for (int i = 0; i < size; i++)
85        {
86            for (int j = 0; j < size; j++)
87            {
88                result[i] = (result[i]+ matrix[i,j] * vector[j]) % mod;
89            }
90        }
91
92        return result;
93    }
94}