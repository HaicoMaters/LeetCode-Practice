public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        int n = rooms.Count; // number of rooms
        Queue<int> keys = new Queue<int>();
        HashSet<int> visited = new HashSet<int>(); // for ignoring duplicate keys

        // Get the keys from room 0
        foreach(int key in rooms[0])
        {
            keys.Enqueue(key);
        }
        visited.Add(0);

        while (keys.Count > 0){
            // Use key
            int room = keys.Dequeue();
            visited.Add(room);

            // Add new keys
            foreach(int key in rooms[room]){
                if(!visited.Contains(key)){ // ignore any duplicate keys
                    keys.Enqueue(key);
                }
            }
        }

        return rooms.Count == visited.Count;
    }
}