using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace UnitWrappers.System.ServiceModel
{
    public class OperationContextExtensionWrap : IExtension<IOperationContext>, IWrap<IExtension<OperationContext>>
    {
        private IExtension<OperationContext> _underlyingObject;

        IExtension<OperationContext> IWrap<IExtension<OperationContext>>.UnderlyingObject { get { return _underlyingObject; } }

        public OperationContextExtensionWrap(IExtension<OperationContext> underlyingObject)
        {
            _underlyingObject = underlyingObject;
        }

        public void Attach(IOperationContext owner)
        {
            OperationContext operationContext = (OperationContextWrap)owner;
            _underlyingObject.Attach(operationContext);
        }

        public void Detach(IOperationContext owner)
        {
            OperationContext operationContext = (OperationContextWrap)owner;
            _underlyingObject.Detach(operationContext);
        }
    }
}
