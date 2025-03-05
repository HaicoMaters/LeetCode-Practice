# LeetCode-Practice

A collection of LeetCode problems showcasing efficient problem-solving techniques.

---

### **Notable Solutions:**

- **[2812 - Find the Safest Path in a Grid](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/2812-FindtheSafestPathinaGrid)**  
  Finds the safest path in a grid by calculating minimum safety at each point using **BFS** and **binary search** for optimal traversal. Time complexity is **O(n²log(n))** with **O(n²)** space.

- **[355 - Design Twitter](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/355-DesignTwitter)**  
  Implements a simplified version of Twitter with features like posting tweets, following users, and retrieving the news feed. Uses a class based approach with **priority queues** for ordering tweets, and **dictionaries**/**hashsets** for managing user relationships.

- **[51 - N-Queens](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/51-N-Queens)**  
  A **backtracking** solution to place N queens on a chessboard such that no two queens threaten each other.

- **[52 - N-Queens II](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/52-N-QueensII)**  
  Extends the N-Queens problem to count all distinct solutions using **backtracking**.

- **[23 - Merge K Sorted Lists](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/23-MergekSortedLists)**  
  Merges K sorted linked lists into one using a **priority queue** (min-heap) to efficiently retrieve the smallest node across lists. **Dummy node** used to simplify list construction. Time complexity is **O(n log k)** with **O(n + k)** space.

- **[494 - Target Sum](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/494-TargetSum)**  
  A **dynamic programming** solution with **memoization** and **backtracking** to find the number of ways to assign '+' and '-' signs to array elements to reach a target sum. Optimized with **state space optimization** to avoid redundant calculations. **Memoization** improves this solutions time and space complexity from **O(2^n)** to **O(n * sum(nums))**.

- **[113 - Path Sum II](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/113-PathSumII)**  
  Uses **DFS** and **backtracking** to find all paths in a binary tree that sum to a target value, maintaining the current path and checking if it matches the target. Time Complexity is **O(n * height)** space is the same.

- **[973 - K Closest Points to Origin](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/973-KClosestPointstoOrigin)**  
  Finds the K closest points to the origin using a **priority queue** (min-heap) and **squared Euclidean distance** for efficient comparison. Space and time complexity optimized to **O(N log K)**.

- **[289 - Game of Life](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/289-GameofLife)**  
  Simulates the **Game of Life** with **in-place updates** using **neighbor counting** and **state encoding** for space optimization. Time complexity is **O(m * n)** with **O(1)** space.

- **[2401 - Longest Nice Subarray](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/2401-LongestNiceSubarray)**  
  Uses **bitwise manipulation** with a **sliding window** approach to find the longest subarray where no two elements share common bits. Time complexity is **O(n)** with **O(1)** space.

--- 
