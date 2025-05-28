// Last updated: 28/05/2025, 13:15:56
public class Solution {
    // Faster DFS solution
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        HashSet<int> visited = new HashSet<int>();
        VisitRooms(rooms, 0, visited);
        return visited.Count == rooms.Count;
    }

    public void VisitRooms(IList<IList<int>> rooms, int room, HashSet<int> visited) {
        if (visited.Contains(room)) return; // skip already visited rooms
        
        visited.Add(room);
        foreach (int key in rooms[room]) {
            VisitRooms(rooms, key, visited); // visit any reachable rooms
        }
    }
}