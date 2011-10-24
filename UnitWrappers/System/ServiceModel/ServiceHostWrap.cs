using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using UnitWrappers.System.ServiceModel.NCommon.Context;

namespace UnitWrappers.System.ServiceModel
{
    /// <summary>
    /// Default <see cref="IServiceHost"/> wrapper.
    /// </summary>
    public class ServiceHostWrap : IServiceHost
    {
        readonly ServiceHostBase UnderlyingObject;

        /// <summary>
        /// Default Constructor.
        /// Creates a new instance of the <see cref="ServiceHostWrap"/> class.
        /// </summary>
        /// <param name="underlyingObject">The <see cref="ServiceHost"/> instance to wrap.</param>
        public ServiceHostWrap(ServiceHostBase underlyingObject)
        {
            UnderlyingObject = underlyingObject;
        }

        /// <summary>
        /// Gets the authorization behavior for the service.
        /// </summary>
        /// <value>A <see cref="ServiceAuthorizationBehavior"/> for the service host.</value>
        public ServiceAuthorizationBehavior Authorization
        {
            get { return UnderlyingObject.Authorization; }
        }

        /// <summary>
        /// Gets the base addresses used by the service host.
        /// </summary>
        /// <value>A <see cref="ReadOnlyCollection{T}"/> that contains the base addresses used by the service host.</value>
        public ReadOnlyCollection<Uri> BaseAddresses
        {
            get { return UnderlyingObject.BaseAddresses; }
        }

        /// <summary>
        /// Gets a collection of channel dispatchers used by he service host.
        /// </summary>
        /// <value>A <see cref="ChannelDispatcherCollection"/> containing the channel dispatchers used by the service host.</value>
        public ChannelDispatcherCollection ChannelDispatchers
        {
            get { return UnderlyingObject.ChannelDispatchers; }
        }

        /// <summary>
        /// Gets or sets the interval of time allowed for the service host to close.
        /// </summary>
        /// <value>A <see cref="TimeSpan"/> that specifies the interval of time allowed for the service host to close.</value>
        public TimeSpan CloseTimeout
        {
            get { return UnderlyingObject.CloseTimeout; }
            set { UnderlyingObject.CloseTimeout = value; }
        }

        /// <summary>
        /// Gets the crendentials for the service host.
        /// </summary>
        /// <value>A <see cref="ServiceCredentials"/> instance.</value>
        public ServiceCredentials Credentials
        {
            get { return UnderlyingObject.Credentials; }
        }

        /// <summary>
        /// Gets the description of the service host.
        /// </summary>
        /// <value>A <see cref="ServiceDescription"/> instance.</value>
        public ServiceDescription Description
        {
            get { return UnderlyingObject.Description; }
        }

        /// <summary>
        /// Gets the extensions registered for the service host.
        /// </summary>
        /// <value>A <see cref="IExtensionCollection{T}"/> contianing extensions registered for the service host.</value>
        public IExtensionCollection<ServiceHostBase> Extensions
        {
            get { return UnderlyingObject.Extensions; }
        }

        /// <summary>
        /// Gets or sets the flow control limit for messages recieved by the service host.
        /// </summary>
        /// <value>int. The flow control limit for messages recieved by the service host.</value>
        public int ManualFlowControlLimit
        {
            get { return UnderlyingObject.ManualFlowControlLimit; }
            set { UnderlyingObject.ManualFlowControlLimit = value; }
        }

        /// <summary>
        /// Gets or sets the interval of time allowed for the service host to open.
        /// </summary>
        /// <value>A <see cref="TimeSpan"/> that specifies the interval of time allowed for the service host to open.</value>
        public TimeSpan OpenTimeout
        {
            get { return UnderlyingObject.OpenTimeout; }
            set { UnderlyingObject.OpenTimeout = value; }
        }

        /// <summary>
        /// Adds a service endpoint to the service host with the specified contract, binding and address.
        /// </summary>
        /// <param name="implementedContract">The contract implemented by the endpoint.</param>
        /// <param name="binding">A <see cref="Binding"/> instnace for the endpoint.</param>
        /// <param name="address">The address for the endpoint.</param>
        /// <returns>A <see cref="ServiceEndpoint"/> instance that was added to the service host.</returns>
        public ServiceEndpoint AddServiceEndpoint(string implementedContract, Binding binding, string address)
        {
            return UnderlyingObject.AddServiceEndpoint(implementedContract, binding, address);
        }

        /// <summary>
        /// Adds a service endpoint to the service host with the specified contract, binding and address.
        /// </summary>
        /// <param name="implementedContract">The contract implemented by the endpoint.</param>
        /// <param name="binding">A <see cref="Binding"/> instnace for the endpoint.</param>
        /// <param name="address">The address for the endpoint.</param>
        /// <returns>A <see cref="ServiceEndpoint"/> instance that was added to the service host.</returns>
        public ServiceEndpoint AddServiceEndpoint(string implementedContract, Binding binding, Uri address)
        {
            return UnderlyingObject.AddServiceEndpoint(implementedContract, binding, address);
        }

        /// <summary>
        /// Adds a service endpoint to the service host with the specified contract, binding and address.
        /// </summary>
        /// <param name="implementedContract">The contract implemented by the endpoint.</param>
        /// <param name="binding">A <see cref="Binding"/> instnace for the endpoint.</param>
        /// <param name="address">The address for the endpoint.</param>
        /// <param name="listenUri">The address at which the endpoint listens for incoming messages.</param>
        /// <returns>A <see cref="ServiceEndpoint"/> instance that was added to the service host.</returns>
        public ServiceEndpoint AddServiceEndpoint(string implementedContract, Binding binding, string address, Uri listenUri)
        {
            return UnderlyingObject.AddServiceEndpoint(implementedContract, binding, address, listenUri);
        }

        /// <summary>
        /// Adds a service endpoint to the service host with the specified contract, binding and address.
        /// </summary>
        /// <param name="implementedContract">The contract implemented by the endpoint.</param>
        /// <param name="binding">A <see cref="Binding"/> instnace for the endpoint.</param>
        /// <param name="address">The address for the endpoint.</param>
        /// <param name="listenUri">The address at which the endpoint listens for incoming messages.</param>
        /// <returns>A <see cref="ServiceEndpoint"/> instance that was added to the service host.</returns>
        public ServiceEndpoint AddServiceEndpoint(string implementedContract, Binding binding, Uri address, Uri listenUri)
        {
            return UnderlyingObject.AddServiceEndpoint(implementedContract, binding, address, listenUri);
        }
    }
}