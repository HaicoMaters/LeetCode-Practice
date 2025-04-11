# LeetCode-Practice

A collection of LeetCode problems showcasing efficient problem-solving techniques.

---

### **Notable Solutions:**

#### **[2812 - Find the Safest Path in a Grid](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/2812-FindtheSafestPathinaGrid)**
- **Description**: Finds the safest path in a grid by calculating minimum safety at each point using **BFS** and **binary search** for optimal traversal.  
- **Time Complexity**: **O(n²log(n))**  
- **Space Complexity**: **O(n²)**
- **Techniques Used**:  
  - **Breadth-First Search (BFS)**
  - **Binary Search**
  - **Grid Traversal**

---

#### **[355 - Design Twitter](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/355-DesignTwitter)**
- **Description**: Implements a simplified version of Twitter with features like posting tweets, following users, and retrieving the news feed.  
- **Techniques Used**:  
  - **Design**
  - **Priority Queue**
  - **Hash Table**

---

#### **[51 - N-Queens](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/51-N-Queens)**
- **Description**: A **backtracking** solution to place N queens on a chessboard such that no two queens threaten each other.  
- **Time Complexity**: **O(N!)**  
- **Space Complexity**: **O(N)**
- **Techniques Used**:  
  - **Backtracking**
  - **DFS**  
  - **Recursion**

---

#### **[52 - N-Queens II](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/52-N-QueensII)**
- **Description**: Extends the N-Queens problem to count all distinct solutions using **backtracking**.  
- **Time Complexity**: **O(N!)**  
- **Space Complexity**: **O(N)**
- **Techniques Used**:  
  - **Backtracking**
  - **DFS**
  - **Recursion**

---

#### **[23 - Merge K Sorted Lists](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/23-MergekSortedLists)**
- **Description**: Merges K sorted linked lists into one using a **priority queue** (min-heap) to efficiently retrieve the smallest node across lists. A **dummy node** is used to simplify list construction.  
- **Time Complexity**: **O(n log k)**  
- **Space Complexity**: **O(n + k)**
- **Techniques Used**:  
  - **Heap**
  - **Linked List**
  - **Divide and Conquer**

---

#### **[494 - Target Sum](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/494-TargetSum)**
- **Description**: A **dynamic programming** solution with **memoization** and **backtracking** to find the number of ways to assign '+' and '-' signs to array elements to reach a target sum. Optimized with **state space optimization** to avoid redundant calculations.  
- **Time Complexity**: **O(n * sum(nums))**  
- **Space Complexity**: **O(n * sum(nums))**
- **Techniques Used**:  
  - **Dynamic Programming**
  - **Backtracking**
  - **Memoization**
  - **DFS**

---

#### **[113 - Path Sum II](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/113-PathSumII)**
- **Description**: Uses **DFS** and **backtracking** to find all paths in a binary tree that sum to a target value, maintaining the current path and checking if it matches the target.  
- **Time Complexity**: **O(n * height)**  
- **Space Complexity**: **O(height)**
- **Techniques Used**:  
  - **DFS**
  - **Backtracking**
  - **Binary Tree**

---

#### **[973 - K Closest Points to Origin](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/973-KClosestPointstoOrigin)**
- **Description**: Finds the K closest points to the origin using a **priority queue** (min-heap) and **squared Euclidean distance** for efficient comparison.  
- **Time Complexity**: **O(N log K)**  
- **Space Complexity**: **O(N)**
- **Techniques Used**:  
  - **Heap**
  - **Sorting**
  - **Geometry**

---

#### **[289 - Game of Life](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/289-GameofLife)**
- **Description**: Simulates the **Game of Life** with **in-place updates** using **neighbor counting** and **state encoding** for space optimization.  
- **Time Complexity**: **O(m * n)**  
- **Space Complexity**: **O(1)**
- **Techniques Used**:  
  - **Simulation**
  - **Matrix**
  - **Game Theory**

---

#### **[2401 - Longest Nice Subarray](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/2401-LongestNiceSubarray)**
- **Description**: Uses **bitwise manipulation** with a **sliding window** approach to find the longest subarray where no two elements share common bits.  
- **Time Complexity**: **O(n)**  
- **Space Complexity**: **O(1)**
- **Techniques Used**:  
  - **Bit Manipulation**
  - **Sliding Window**
  - **Array**

---

#### **[138 - Copy List with Random Pointer](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/138-CopyListwithRandomPointer)**
- **Description**: Creates a deep copy of a linked list with next and random pointers using **constant space** by interleaving the copied nodes within the original list. The random pointers are then assigned by leveraging the interleaved structure. The list is separated into the original and copied lists at the end.  
- **Time Complexity**: **O(n)**  
- **Space Complexity**: **O(1)** auxiliary space
- **Techniques Used**:  
  - **Linked List**
  - **DFS**
  - **Graph**
 

---

#### **[208 - Implement Trie (Prefix Tree)](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/208-ImplementTrie(PrefixTree))**
- **Description**: Implements a Trie (Prefix Tree) data structure, which supports efficient insert, search, and prefix checking operations. The Trie is built using **TrieNode** objects that store a dictionary of child nodes, enabling quick access to characters in a word or prefix.  
  - **Insert**: Adds a word to the Trie, creating new nodes for characters that don't exist already.
  - **Search**: Checks whether a word exists in the Trie.
  - **StartsWith**: Checks if any word in the Trie starts with a given prefix.
  
- **Time Complexity**: **O(n)**, where `n` is the length of the word being inserted, searched, or checked for prefix.
- **Space Complexity**: **O(n)**, where `n` is the total number of characters stored in the Trie (including all words inserted).
- **Techniques Used**:  
  - **Trie**
  - **Hash Table**
  - **Design**

---

#### **[427 - Construct QuadTree](https://github.com/HaicoMaters/LeetCode-Practice/tree/main/427-ConstructQuadTree)**
- **Description**: Builds a **quad tree** from a binary grid where each node represents a uniform subregion (either all 0s or all 1s). If a region is not uniform, it is divided into four quadrants recursively. The implementation tracks subgrid bounds for each node using a dictionary to support recursive construction of the tree.
- **Time Complexity**: **O(n² log n)** – Each cell is visited exactly once during leaf determination n² and then log n for the number of recursive levels (as the grid size keeps being split into 4).
- **Space Complexity**: **O(n²)** – In the worst case, each cell becomes a leaf node in the quad tree.
- **Techniques Used**:  
  - **Recursion**  
  - **Divide and Conquer**  
  - **Tree Construction**  
  - **2D Grid Processing**

---

### **Some Techniques Used Across Other Problems:**

**Quickselect**, **Trie**, **Tree**, **Depth-First Search (DFS)**, **Breadth-First Search (BFS)**, **Bit Manipulation**, **Binary Search**, **Sorting**, **Two Pointers**, **Linked List**, **Stack**, **Matrix**, **Divide and Conquer**, **Dynamic Programming**

---
