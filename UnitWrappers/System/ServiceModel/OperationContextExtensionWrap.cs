using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace UnitWrappers.System.ServiceModel
{
    public class OperationContextExtensionWrap : IExtension<IOperationContext> 
    {
        public IExtension<OperationContext> UnderlyingObject { get; private set; }

        public OperationContextExtensionWrap(IExtension<OperationContext> underlyingObject)
        {
            UnderlyingObject = underlyingObject;
        }

        public void Attach(IOperationContext owner)
        {
            var wrap = (OperationContextWrap) owner;
            UnderlyingObject.Attach(wrap.UnderlyingObject);
        }

        public void Detach(IOperationContext owner)
        {
            var wrap = (OperationContextWrap)owner;
            UnderlyingObject.Detach(wrap.UnderlyingObject);
        }
    }
}
