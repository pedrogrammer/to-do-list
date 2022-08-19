using ToDoList.Model;
using Task = ToDoList.Model.Task;

namespace ToDoList.Data
{
	public class TaskService
	{
		public static List<Task> Tasks { get; set; }

		public TaskService()
		{
			if (Tasks == null)
			{
				Tasks = new List<Task>();

                Tasks.Add(new Task()
                {
                    Id = 1,
                    Title = "Wake up",
                    Description = "At 7 A.M.",
                    IsDone = true,
                });

                Tasks.Add(new Task()
                {
                    Id = 2,
                    Title = "Brush teeth",
                    Description = "To have a fresh breath",
                    IsDone = false,
                });
            }
        }

        public void AddTask(Task newTask)
        {
            newTask.Id = Tasks.Max(x => x.Id) + 1;
            Tasks.Add(newTask);
        }

        public List<Task> GetTasks()
        {
            return Tasks;
        }

        public void DeleteTask(int id)
        {
            var task = Tasks.Where(x => x.Id == id).FirstOrDefault();
            if (task != null)
            {
                Tasks.Remove(task);
            }
        }
	}
}
