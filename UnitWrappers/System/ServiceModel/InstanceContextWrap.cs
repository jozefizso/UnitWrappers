using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;
using UnitWrappers.System.ServiceModel.NCommon.Context;

namespace UnitWrappers.System.ServiceModel
{
    /// <summary>
    /// Default implementation of <see cref="IInstanceContext"/>
    /// </summary>
    public class InstanceContextWrap : IInstanceContext
    {
        readonly InstanceContext UnderlyingObject;

        /// <summary>
        /// Default Constructor.
        /// Creates a new instance of the <see cref="InstanceContextWrap"/> class.
        /// </summary>
        /// <param name="underlyingObject">The <see cref="InstanceContext"/> instance to wrap.</param>
        public InstanceContextWrap(InstanceContext underlyingObject)
        {
            UnderlyingObject = underlyingObject;
        }

        /// <summary>
        /// Gets the underlying <see cref="IExtensionCollection{T}"/> from the underlying
        /// <see cref="InstanceContext"/>.
        /// </summary>
        public IExtensionCollection<InstanceContext> Extensions
        {
            get { return UnderlyingObject.Extensions; }
        }

        IServiceHost IInstanceContext.Host
        {
            get { return Host; }
        }

        /// <summary>
        /// Gets a <see cref="IServiceHost"/> instance that wraps the underlying <see cref="ServiceHost"/>
        /// from the InstanceContxt.
        /// </summary>
        public IServiceHost Host
        {
            get { return new ServiceHostWrap(UnderlyingObject.Host); }
        }

        /// <summary>
        /// Gets a <see cref="ICollection{T}"/> instance containing a list of incoming channels
        /// from the wrapped <see cref="InstanceContext"/>.
        /// </summary>
        public ICollection<IChannel> IncomingChannels
        {
            get { return UnderlyingObject.IncomingChannels; }
        }

        /// <summary>
        /// Gets or sets the manual flow control limit on the wrapped <see cref="InstanceContext"/>.
        /// </summary>
        public int ManualFlowControlLimit
        {
            get { return UnderlyingObject.ManualFlowControlLimit; }
            set { UnderlyingObject.ManualFlowControlLimit = value; }
        }

        /// <summary>
        /// Gets a <see cref="ICollection{T}"/> instance containing a list of outgoing channels
        /// from the wrapped <see cref="InstanceContext"/>.
        /// </summary>
        public ICollection<IChannel> OutgoinChannels
        {
            get { return UnderlyingObject.OutgoingChannels; }
        }

        /// <summary>
        /// Gets the <see cref="SynchronizationContext"/> from the wrapped <see cref="InstanceContext"/>.
        /// </summary>
        public SynchronizationContext SynchronizationContext
        {
            get { return UnderlyingObject.SynchronizationContext; }
            set { UnderlyingObject.SynchronizationContext = value; }
        }

        /// <summary>
        /// Increments the manual control flow limit
        /// </summary>
        /// <param name="limit">int. The flow control limit to increment to.</param>
        public void IncrementManualFlowControlLimit(int limit)
        {
            UnderlyingObject.IncrementManualFlowControlLimit(limit);
        }

        /// <summary>
        /// Gets the service instance.
        /// </summary>
        /// <returns>object.</returns>
        public object GetServiceInstance()
        {
            return UnderlyingObject.GetServiceInstance();
        }

        /// <summary>
        /// Gets the service instance for the specified <see cref="Message"/>.
        /// </summary>
        /// <param name="message">A <see cref="Message"/> instance.</param>
        /// <returns>object.</returns>
        public object GetServiceInstance(Message message)
        {
            return UnderlyingObject.GetServiceInstance(message);
        }



    }
}