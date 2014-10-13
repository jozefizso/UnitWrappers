using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime;


namespace UnitWrappers.System.Diagnostics
{
    /// <inheritdoc />
    public class TraceSourceWrap : ITraceSource,IWrap<TraceSource>
    {

        public TraceSource _underlyingObject;
        TraceSource IWrap<TraceSource>.UnderlyingObject { get { return _underlyingObject; } }

        public static implicit operator TraceSourceWrap(TraceSource o)
        {

            return new TraceSourceWrap(o);
        }

        public static implicit operator TraceSource(TraceSourceWrap o)
        {
            return o._underlyingObject;
        }

   
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public TraceSourceWrap(string name)
        {
            _underlyingObject = new TraceSource(name);
        }

     
        public TraceSourceWrap(string name, SourceLevels defaultLevel)
        {
            _underlyingObject = new TraceSource(name, defaultLevel);
        }

     
        public TraceSourceWrap(TraceSource traceSource)
        {
            _underlyingObject = traceSource;
        }    


        /// <inheritdoc />
        public StringDictionary Attributes
        {
            get { return _underlyingObject.Attributes; }
        }

        /// <inheritdoc />
        public TraceListenerCollection Listeners
        {
            get { return _underlyingObject.Listeners; }
        }

        /// <inheritdoc />
        public string Name
        {
            get { return _underlyingObject.Name; }
        }

        /// <inheritdoc />
        public SourceSwitch Switch
        {
            get { return _underlyingObject.Switch; }
            set { _underlyingObject.Switch = value; }
        }
   
        /// <inheritdoc />
        public void Close()
        {
            _underlyingObject.Close();
        }

        /// <inheritdoc />
        public void Flush()
        {
            _underlyingObject.Flush();
        }

        /// <inheritdoc />
        public void TraceData(TraceEventType eventType, int id, object data)
        {
            _underlyingObject.TraceData(eventType, id, data);
        }

        /// <inheritdoc />
        public void TraceData(TraceEventType eventType, int id, params object[] data)
        {
            _underlyingObject.TraceData(eventType, id, data);
        }

        /// <inheritdoc />
        public void TraceEvent(TraceEventType eventType, int id)
        {
            _underlyingObject.TraceData(eventType, id);
        }

        /// <inheritdoc />
        public void TraceEvent(TraceEventType eventType, int id, string message)
        {
            _underlyingObject.TraceData(eventType, id, message);
        }

        /// <inheritdoc />
        public void TraceEvent(TraceEventType eventType, int id, string format, params object[] args)
        {
            _underlyingObject.TraceData(eventType, id, format, args);
        }

        /// <inheritdoc />
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public void TraceInformation(string message)
        {
            _underlyingObject.TraceInformation(message);
        }

        /// <inheritdoc />
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public void TraceInformation(string format, params object[] args)
        {
            _underlyingObject.TraceInformation(format, args);
        }

        /// <inheritdoc />
        public void TraceTransfer(int id, string message, Guid relatedActivityId)
        {
            _underlyingObject.TraceTransfer(id, message, relatedActivityId);
        }
    }
}