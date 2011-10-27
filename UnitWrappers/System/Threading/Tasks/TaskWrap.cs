using System.Threading.Tasks;

namespace UnitWrappers.System.Threading.Tasks
{
    public class TaskWrap : ITask
    {
        public TaskWrap(Task task )
        {
             
            UnderlyingObject = task;
        }

        public Task UnderlyingObject { get; set; }

        public void Start()
        {
            UnderlyingObject.Start();
        }

        public void Wait()
        {
            UnderlyingObject.Wait();
        }
    }
}
