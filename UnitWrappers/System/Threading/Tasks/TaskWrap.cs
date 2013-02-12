using System;
using System.Threading;
using System.Threading.Tasks;

namespace UnitWrappers.System.Threading.Tasks
{
    public class TaskWrap : ITask,IWrap<Task>
    {
        public TaskWrap(Task task )
        {
            _underlyingObject = task;
        }

        public TaskWrap(Action action)
        {
            _underlyingObject = new Task(action);
        }

        public static implicit operator TaskWrap(Task o)
        {
            return new TaskWrap(o);
        }

        public static implicit operator Task(TaskWrap o)
        {
            return o._underlyingObject;
        }

        public Task _underlyingObject;

        Task IWrap<Task>.UnderlyingObject { get { return _underlyingObject; } }

        public bool IsCompleted
        {
            get { return _underlyingObject.IsCompleted; }
        }

        WaitHandle IAsyncResult.AsyncWaitHandle
        {
            get { return (_underlyingObject as IAsyncResult).AsyncWaitHandle; }
        }

        public object AsyncState
        {
            get { return _underlyingObject.AsyncState; }
        }

        bool IAsyncResult.CompletedSynchronously
        {
            get { return (_underlyingObject as IAsyncResult).CompletedSynchronously; }
        }

        public TaskCreationOptions CreationOptions 
        {
            get { return _underlyingObject.CreationOptions; }
        }

        public AggregateException Exception
        {
            get { return _underlyingObject.Exception; }
        }

        public int Id { get { return _underlyingObject.Id; }}

        public bool IsFaulted { get { return _underlyingObject.IsFaulted; } }

        public bool IsCanceled
        {
            get { return _underlyingObject.IsCanceled; }
        }

        public TaskStatus Status { get { return _underlyingObject.Status; } }

        public void Start()
        {
            _underlyingObject.Start();
        }

        public void Wait()
        {
            _underlyingObject.Wait();
        }



        public void Dispose()
        {
            _underlyingObject.Dispose();
        }

      
    }
}
