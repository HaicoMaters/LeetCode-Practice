// Last updated: 18/09/2025, 13:04:56
public class Task {
    public int id;
    public int priority;
    public int userId;

    public Task(int User, int ID, int Prio)
    {
        id = ID;
        priority = Prio;
        userId = User;
    }
}

public class TaskManager {

    Dictionary<int, Task> idToTask;

    // maxheap so -prio and -id to sort (sort by highest prio then highest id if same prios)
    PriorityQueue<(Task current, int prio), (int negPrio, int negId)> queue;

    public TaskManager(IList<IList<int>> tasks) {
        idToTask = new Dictionary<int, Task>();
        queue = new PriorityQueue<(Task current, int prio), (int negPrio, int negId)>();

        foreach (var task in tasks)
        {
            int userId = task[0];
            int id = task[1];
            int priority = task[2];

            Add(userId, id, priority);
        }
    }
    
    public void Add(int userId, int taskId, int priority) {
        Task t = new Task(userId, taskId, priority);
        idToTask[taskId] = t;
        
        queue.Enqueue((t, priority), (-priority, -taskId));
    }
    
    public void Edit(int taskId, int newPriority) {
        if (!idToTask.ContainsKey(taskId)) return;

        Task task = idToTask[taskId];

        if (task.priority == newPriority) return;

        task.priority = newPriority;                
        queue.Enqueue((task, newPriority), (-newPriority, -taskId));     
    }
    
    public void Rmv(int taskId) {
        // no need to remove from queue can just deal with in exec top seeing no task with that id in dict
        idToTask.Remove(taskId);
    }
    
    public int ExecTop() {
        while (queue.Count > 0)
        {
            (Task t, int prio) = queue.Dequeue();

            // skip removed tasks
            if (!idToTask.ContainsKey(t.id))
            {
                continue;
            }

            // skip changed tasks
            if (idToTask[t.id].priority != prio)
            {
                continue;
            }

            // skip outdated tasks
            if (t.userId != idToTask[t.id].userId)
            {
                continue;
            }

            Rmv(t.id);
            return t.userId;
        }

        return -1;
    }
}

/**
 * Your TaskManager object will be instantiated and called as such:
 * TaskManager obj = new TaskManager(tasks);
 * obj.Add(userId,taskId,priority);
 * obj.Edit(taskId,newPriority);
 * obj.Rmv(taskId);
 * int param_4 = obj.ExecTop();
 */