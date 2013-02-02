using System;
using System.Threading;
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

        public bool IsCompleted
        {
            get { return UnderlyingObject.IsCompleted; }
        }

        WaitHandle IAsyncResult.AsyncWaitHandle
        {
            get { return (UnderlyingObject as IAsyncResult).AsyncWaitHandle; }
        }

        public object AsyncState
        {
            get { return UnderlyingObject.AsyncState; }
        }

        bool IAsyncResult.CompletedSynchronously
        {
            get { return (UnderlyingObject as IAsyncResult).CompletedSynchronously; }
        }

        public TaskCreationOptions CreationOptions 
        {
            get { return UnderlyingObject.CreationOptions; }
        }

        public AggregateException Exception
        {
            get { return UnderlyingObject.Exception; }
        }

        public int Id { get { return UnderlyingObject.Id; }}

        public bool IsFaulted { get { return UnderlyingObject.IsFaulted; } }

        public bool IsCanceled
        {
            get { return UnderlyingObject.IsCanceled; }
        }

        public TaskStatus Status { get { return UnderlyingObject.Status; } }

        public void Start()
        {
            UnderlyingObject.Start();
        }

        public void Wait()
        {
            UnderlyingObject.Wait();
        }



        public void Dispose()
        {
            UnderlyingObject.Dispose();
        }
    }
}
