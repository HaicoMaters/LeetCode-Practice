# DFS with cycle detection solution

# Advantages of DFS (THIS SOLUTION):
# 1. Direct cycle detection: Naturally detects cycles, making it easy to identify circular dependencies.
# 2. Memory efficient: Uses the call stack, so it requires less memory than BFS.

# Disadvantages of DFS (THIS SOLUTION):
# 1. Stack overflow: Risk of stack overflow in deep graphs due to recursion.
# 2. Complex state management: Requires manual tracking of node states (unvisited, visiting, visited).
# 3. Less efficient for topological sorting: Not as straightforward for level-based processing.

# Advantages of BFS (Kahn's Algorithm) (THE C# SOLUTION):
# 1. No recursion: Avoids stack overflow issues and is safer for deep graphs.
# 2. Natural for topological sorting: Efficiently processes nodes in level-order.
# 3. Better for broad graphs: Performs well with graphs having many branches.

# Disadvantages of BFS (THE C# SOLUTION):
# 1. Higher memory usage: Needs extra space for the queue.
# 2. Slower for deep graphs: May take longer for deeply nested graphs.


class Solution:
    def canFinish(self, numCourses: int, prerequisites: list[list[int]]) -> bool:
        # Create an adjacency list to represent the graph
        adj_list = {i: [] for i in range(numCourses)}
        
        # Fill the adjacency list with the prerequisites
        for course, prerequisite in prerequisites:
            adj_list[course].append(prerequisite)
        
        # States for each course: 0 = unvisited, 1 = visiting, 2 = visited
        state = [0] * numCourses
        
        def dfs(course: int) -> bool:
            if state[course] == 1:
                # Cycle detected, because this course is currently being visited
                return False
            if state[course] == 2:
                # Already visited, no need to process again
                return True
            
            # Mark the course as visiting
            state[course] = 1
            
            # Visit all prerequisites for the course
            for prerequisite in adj_list[course]:
                if not dfs(prerequisite):
                    return False
            
            # Mark the course as visited
            state[course] = 2
            return True
        
        # Iterate over all courses and check for cycles
        for course in range(numCourses):
            if state[course] == 0:  # If the course is unvisited
                if not dfs(course):
                    return False
        
        return True